using Microsoft.AspNetCore.Mvc;
using KZtask.Models;
using Microsoft.EntityFrameworkCore;

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
                        if(db.Authorization.First(p => p.Id == user.Id).Id == user.Id && db.Authorization.First(p => p.Id == user.Id).Password == user.Password)
                        {
                            return Redirect("/list/Index?id=" + user.Id);
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
