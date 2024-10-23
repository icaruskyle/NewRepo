using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeventeenHUB.Controllers
{
    public class SeventeenController : Controller
    {
        // GET: SeventeenController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeventeenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SeventeenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeventeenController/Create
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

        // GET: SeventeenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeventeenController/Edit/5
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

        // GET: SeventeenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SeventeenController/Delete/5
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
