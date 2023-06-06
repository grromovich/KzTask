using Microsoft.AspNetCore.Mvc;
using KZtask.Models;
using Microsoft.EntityFrameworkCore;
using System;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace KZtask.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AppDbContext())
                {
                    try
                    {
                        if(db.Users.FirstOrDefault(p => p.Id == user.Id && p.Password == user.Password) != null)
                        {
                            var claims = new List<Claim>
                            {
                                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id),
                            };
                            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                            HttpContext.SignInAsync(claimsPrincipal);
                            return Redirect("/list/Index");
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewData["error"] = "Неправильный логин или пароль";
                    }
                }
            }
            return View("Index");
        }
    }
}
