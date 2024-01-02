using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;

namespace Security_Guard.Controllers
{
    public class NeighborsController : Controller
    {
        private DBContext Context { get; set; }
        public NeighborsController(DBContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IQueryable<Neighbor> queryNeighbors = Context.Neighbors.OrderBy(n => n.Id);

            List<Neighbor> Neighbors = queryNeighbors.ToList();
            ViewBag.Neighbors = Neighbors;
            return View();
        }
        [HttpGet]
        public IActionResult AddNeighbor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var hotelToDelete = Context.Neighbors.OrderBy(f => f.Id).First(h => h.Id == id);

            if (hotelToDelete != null)
            {
                Context.Neighbors.Remove(hotelToDelete);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddNeighbor(Neighbor newNeighbor)
        {
            int newId = Context.Neighbors.ToList().Count > 0 ? Context.Neighbors.Max(h => h.Id) + 1 : 1;
            newNeighbor.Id = newId;
            Context.Neighbors.Add(newNeighbor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ViewNeighbor(int id)
        {
            var Neighbor = Context.Neighbors.First(h => h.Id == id);
            ViewBag.Neighbor = Neighbor;
            return View();
        }
    }
}
