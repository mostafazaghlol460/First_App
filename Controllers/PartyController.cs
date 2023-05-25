using First_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Controllers
{
    public class PartyController : Controller
    {
        DBParty db = new DBParty();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult add_party()
        {
            return View();
        }
        public IActionResult ADD_DATA(Party p1, string attend)
        {
            if (attend == "attend")
            {
                p1.attend = true;
            }
            db.Add(p1);
            db.SaveChanges();
            if (p1.attend == true)
            {
                return RedirectToAction("ThanksPage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Messsage()
        {
            var display = db.Parties.ToList();
            return View( display);
        }
        public IActionResult ThanksPage()
        {
            return View();
        }
        public IActionResult getall()
        {
            var dispaly =db.Parties.Where(n=>n.attend==true).ToList();
            return View(dispaly);
        }
    }
}
