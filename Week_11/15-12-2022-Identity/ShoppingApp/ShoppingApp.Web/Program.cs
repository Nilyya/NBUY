using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db")); 
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    // ýdentity paketi ile ilgili yaplacaklar.
    
    #region PasswordSettings
    options.Password.RequireDigit = true; //þifre içinde rakam bulunsun.
    options.Password.RequireLowercase = true; //þifre içinde küçükharf bulunsun.
    options.Password.RequireUppercase = true; //þifre içinde kbüyükharf bulunsun.
    options.Password.RequiredLength = 6; //þifre en az   karakterbulunsun.
    options.Password.RequireNonAlphanumeric = true; //þifre içinde en az bir alfanümerik karakter(.,/& gibi) bulunmasý zorunlu olsun.

    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts = 5;//kullanýcý en fazla 5 kez hatalý girerse hesabý kilitleme koþulu
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5); //Kilitlenmþ hesaplar için 5 dk sonra tekrar deneyebilir.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; //Benzersiz e-mail adresi ile kayýt olunabilir.
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; //true ise email onayý aktifdir.
    options.SignIn.RequireConfirmedPhoneNumber = false; // trueise telefo numarasý onayý aktiftir.
    #endregion

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //Eðer açýlabilmesi login oldumanýn zorunlu olduðu bir istekte bulunursa kullanýcýn yönlendirileceði sayfa burasý olacak (account controllündeki login action metodu.)
    options.LogoutPath= "/account/logout"; // kullanýcý çýkýþ yaptýðýnda yönlendirilecek sayfa.
    options.AccessDeniedPath= "/account/accessdenied"; //Yetkisiz giriþ sýrasýnda yönlendrilecek sayfa
    options.SlidingExpiration = true; // cokkie yaratýldýðýnda yaþam süresi 20 dk'dýr eðer bu true ise her yeni istekte yaþam süresi yeniden baþlar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5); //yaþam süresini ayarlar   
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //http ile çalýþacak
        Name = ".ShoppingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict

    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(
    "smtp.office365.com",587,true,"wissen_core@hotmail.com","Wissen123."
    ));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
