using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalAirpro.Controllers
{
    public class AirpagesController : Controller
    {
        // GET: AirpagesController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: AirpagesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AirpagesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AirpagesController1/Create
        

        // GET: AirpagesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AirpagesController1/Edit/5
        

        // GET: AirpagesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
    }
}
