using CinemaManager_GDG1.Models.Cinema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManager_GDG1.Controllers
{
    public class ProducersController : Controller
    {
        CinemaDbGdg1Context _context;
        public ProducersController(CinemaDbGdg1Context context)
        {
            _context = context;
        }
        // GET: ProducersController
        public ActionResult Index()
        {
            return View(_context.Producers);
        }

        // GET: ProducersController/Details/5
        public ActionResult Details(int id)
        {
            Producer prod = _context.Producers.Find(id);
            return View(prod);
        }

        // GET: ProducersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producer p)
        {
            try
            {
                _context.Producers.Add(p);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProducersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProducersController/Edit/5
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

        // GET: ProducersController/Delete/5
        public ActionResult Delete(int id)
        {
            Producer prod = _context.Producers.Find(id);
            return View(prod);
        }

        // POST: ProducersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Producer p)
        {
            try
            {
                _context.Producers.Remove(p);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
