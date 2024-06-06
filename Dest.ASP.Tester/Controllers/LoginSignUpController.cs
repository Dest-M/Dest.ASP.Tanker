using Dest.ASP.Tester.Game;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dest.ASP.Tester.Controllers
{
    public class LoginSignUpController(IProfile _profile) : Controller
    {
        // GET: LoginSignUpController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginSignUpController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginSignUpController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginSignUpController/Create
        [HttpPost]

        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginSignUpController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginSignUpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login(int id, IFormCollection collection)
        {
            
            var a = _profile.ValidateProfile(collection["name"], collection["pass"]);
            if (a==true) return RedirectToAction("Gamescreen", "Home");
            else return RedirectToAction(null, "Home");
        }
        // GET: LoginSignUpController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginSignUpController/Delete/5
        [HttpPost]
 
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
