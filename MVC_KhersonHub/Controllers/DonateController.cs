using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_KhersonHub.Controllers
{
    public class DonateController : Controller
    {
        // GET: DonateController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DonateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: DonateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonateController/Edit/5
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

        // GET: DonateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
