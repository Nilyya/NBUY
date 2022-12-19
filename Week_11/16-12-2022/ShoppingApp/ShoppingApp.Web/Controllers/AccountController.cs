using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginDto { ReturnUrl=returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user==null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }
                //Bu noktada email onayı yapılıp yapılmadığını kontrol edeceğiz.
                if (await _userManager.IsEmailConfirmedAsync(user))
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Hesabınız onaylanmamış lütfen mailinize girip onay işlemini tamamlayınız.", "warning");
                    return View(loginDto);
                    //ÖDEV:eğer hesap onaylı değilse burada kullanıcıya onay linki gönder maili gözüksün.Ve butona basıldığında tekrar onay maili yollasın.Mail adresi ve gönder buttonlu bir form oluştur. 
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı!");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        //[ValidateAntiForgeryToken]
        //İlgili cookienin sadece ait olduğu tarayıcı tarafından gönderilmesi halinde geçerli olmasını sağlar.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email
                };
                var result = await _userManager.CreateAsync(user, registerDto.Password);
                if (result.Succeeded)
                {
                    //Generate token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = tokenCode
                    });
                    Console.WriteLine(url);
                    //Mailin gönderilme, onaylanma vs
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1><br><p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:7215{url}'>Onay Linki</a>");
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Lütfen mail hesabınızı kontrol ediniz gelen linki tıklayarak hesabınızı onaylayınız.", "warning");
                    return RedirectToAction("Login","Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz");
            return View(registerDto);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId==null || token == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Geçersiz bilgi.", "danger");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Hesap onayınız tamamlanmıştır.", "success");
                    return RedirectToAction("Login","Account");
                }
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun oluştu tekrar deneyiniz.", "danger");
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Lütfen mail adresinizi eksiksiz giriniz.", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Lütfen mail adresini kontrol ediniz", "danger");
                return View();
            }
            var tokenCode=await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                UserId= user.Id,
                token=tokenCode
             });
            await _emailSender.SendEmailAsync(
                email,
                "ShoppingApp Şifre sıfırlama linki",
                $"Lütfen paralo yenilemek için <a href='https:/localhost:7215{url}'>tıklayınız</a>");
            TempData["Message"] = Jobs.CreateMessage("Bilgi", "Lütfen mail hesabınızı kontrol ediniz gelen linki tıklayarak hesabınızı onaylayınız.", "info");
            return RedirectToAction("Login","Account");
        }
        public IActionResult ResetPassword(string userId,string token)
        {
            if (userId==null ||token==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "bir sorun oluştuz.", "danger");
                return RedirectToAction("Index", "Home");
            }
            var resetPasswordDto = new ResetPasswordDto
            {
                Token = token
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordDto);
            }
            var user=await _userManager.FindByEmailAsync(resetPasswordDto.Email);
            if (user==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "bir sorun oluştuz.", "danger");
                return View(resetPasswordDto);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = Jobs.CreateMessage("Başarılı", "Şifreniz başarıyla değiştirilmiştir.", "success");
                return RedirectToAction("Login", "Account");
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "bir sorun oluştuz.", "danger");
            return RedirectToAction("Index", "Home");
        }
    }
}
