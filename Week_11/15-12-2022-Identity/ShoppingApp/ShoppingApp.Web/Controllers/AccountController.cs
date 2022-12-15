using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signManager;
        private readonly IEmailSender emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
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
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı.");
                    return View(loginDto);
                }
                // Bu noktada e-mail onayı yapılıp yaplmadığını kontrol edeceğiz.
                var result = await _signManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi yada parola hatalı");
            }
            return View(loginDto);
        }
        public IActionResult Register()
        {
       
            return View();
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]//ilgili cookie sadece ait olduğu tarayıcı tarafından gönderilmesini sağlar.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email,
                };
               var result= await _userManager.CreateAsync(user, registerDto.Password);
                if (result.Succeeded)
                {
                    //Generate token(mail onayı için)
                    var tokenCode=await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url= Url.Action("ConfirmEmail","Account",new { 
                    userId=user.Id,
                    token=tokenCode
                    });

                    //Mailin gönderilmesi, onaylanması vs
                    await _emailSender.SendEmailAsync(user.Email,"ShoppingApp Hesap Onaylama",$"<h1>Merhaba</h1>"+$"<br>"+$"<p>Lütfen hesabınızı onaylamak için linke tıklayınız</p>"+$"<a href='https://Localhost:5178{url}'></a>");
                    ViewBag.Message = "Kayıt işlemini tamamlamak için gelen maile tıklayınız.";
                    return RedirectToAction("Login","Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu lütfen tekrar deneyiniz");
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if (userId==null || token==null)
            {
                ViewBag.Message("Geçersiz");
                return View();
            }
            var user=await _userManager.FindByEmailAsync(userId);
            if (user!=null) {
            var result=await _userManager.ConfirmEmailAsync(user,token);
                if (result.Succeeded)
                {
                    ViewBag.Message("Hesabımız başarıyla onaylandı");
                }
            }
            ViewBag.Message("Bir sorun oluştu hesabınız onaylanmadı, tekrar deneyiniz.");
            return View();
        }
    }
}
