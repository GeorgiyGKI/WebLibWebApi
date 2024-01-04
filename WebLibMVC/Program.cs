using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http.Features;
using System;
using WebLibMVC.Extensions;
using WebLibMVC.Handler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureServiceManager();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient("weblib_api", User => User.BaseAddress = new Uri("https://localhost:5001"))
                .AddHttpMessageHandler<AuthorizationHeaderHandler>();//без этого в отправленых запросах от clien'a не будет в заголовке
                                                                     //Authorization, Bearer + token, не понимаю почему, может отличаютс€ настройки JWT у двух проектов, может еще из-за чего 
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<AuthorizationHeaderHandler>();
builder.Services.AddAuthentication();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.IsEssential = true;
});

//builder.Services.AddDistributedMemoryCache();
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 2097152; // 2 мегабайта (в байтах)
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always,
});

app.Use(async (context, next) =>
{
    var token = context.Request.Cookies[".AspNetCore.Application.Id"];
    if (!string.IsNullOrEmpty(token))
    {
        context.Request.Headers.Add("Authorization", "Bearer " + token);
    }
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    if (context.Response.StatusCode == 401)
    {
        context.Response.Redirect("/Authorize/Login"); // ѕеренаправление на страницу входа
    }

    await next();
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
