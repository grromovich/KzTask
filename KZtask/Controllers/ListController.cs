using KZtask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace KZtask.Controllers
{
    [Authorize()]
    public class ListController : Controller
    {
        public IActionResult Index(string id)
        {
            using (var db = new AppDbContext())
            {
                try
                {
                    var login = HttpContext.User.FindFirst(ClaimsIdentity.DefaultNameClaimType);
                    List<Test> texts = db.Tasks.AsNoTracking().Where(b => b.Id == login.Value).ToList();
                    ViewBag.list = texts;
                    ViewData["Username"] = login?.Value;
                }
                catch (Exception ex)
                {

                }
            }
            return View();
        }
    }
}
