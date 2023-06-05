using KZtask.Models;
using Microsoft.AspNetCore.Mvc;

namespace KZtask.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index(string id)
        {
            using (var db = new AppDbContext())
            {
                try
                {
                    List<Test> texts = db.Test.AsEnumerable().Where(b => (b.Id == id)).ToList();
                    ViewBag.list = texts;
                    ViewData["Username"] = id;
                }
                catch (Exception ex)
                {

                }
            }
            return View();
        }
    }
}
