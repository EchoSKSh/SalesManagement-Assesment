using SalesManagement.BLL;
using SalesManagement.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesManagement.UI.Controllers
{
    public class WorkRouteController : Controller
    {

        private SalesManagementBll _db;

        public WorkRouteController()
        {
            _db = new SalesManagementBll();
        }

        // GET: WorkRoute
        public ActionResult Index()
        {
            var workRoutes = _db.GetAllWorkRoutess();
            return View(workRoutes);
        }

        public ActionResult WorkRouteForm()
        {                      
            return View();
        }

        public ActionResult WorkRouteDetails(int? id)
        {
            var workRoute = _db.GetWorkRouteById(id);
            

            if (workRoute == null)
            {
                return HttpNotFound();
            }
           
            return View(workRoute);
        }

        public ActionResult Edit(int? id)
        {
            var workRoute = _db.GetWorkRouteById(id);
           

            if (workRoute == null)
            {
                return HttpNotFound();
            }           

            return View(workRoute);
        }



        [HttpPost]
        public ActionResult Edit(WorkRoute workRoute)
        {
            if (ModelState.IsValid)
            {
                _db.UpdateWorkRoute(workRoute);
            }

            return RedirectToAction("Index", "WorkRoute");
        }

        public ActionResult Delete(int? id)
        {
            var workRoute = _db.GetWorkRouteById(id);
           

            if (workRoute == null)
            {
                return HttpNotFound();
            }

            
            return View(workRoute);
        }

        [HttpPost]
        public ActionResult Delete(WorkRoute workRoute)
        {
            _db.RemoveWorkRoute(workRoute.Id);
            return RedirectToAction("Index", "WorkRoute");
        }

        [HttpPost]
        public ActionResult Create(WorkRoute workRoute)
        {
            _db.AddWorkRoute(workRoute);


            return RedirectToAction("Index", "WorkRoute");
        }
    }
}