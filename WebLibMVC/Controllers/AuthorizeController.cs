using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace WebLibMVC.Controllers
{
    public class AuthorizeController : Controller
    {
        private readonly IServiceManager _service;
        public AuthorizeController(IServiceManager serviceManager) =>
            _service = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AuthorizeViewModel authorizeViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var token = await _service.AuthorizeService.AuthorizeAsync(authorizeViewModel);

                    HttpContext.Response.Cookies.Append(
                        ".AspNetCore.Application.Id", 
                        token,
                        new CookieOptions {MaxAge = TimeSpan.FromMinutes(10)});
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "Incorrect username or password");
                    TempData["ErrorMessage"] = "Incorrect username or password";
                    return View();
                }
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            Response.Cookies.Delete(".AspNetCore.Application.Id");

            return RedirectToAction("Index", "Home");
        }
    }
}