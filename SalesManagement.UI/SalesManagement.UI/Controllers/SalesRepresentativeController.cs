using SalesManagement.BLL;
using SalesManagement.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesManagement.UI.Controllers
{
    public class SalesRepresentativeController : Controller
    {
        private SalesManagementBll _db;

        public SalesRepresentativeController()
        {
            _db = new SalesManagementBll();
        }

        // GET: SalesRepresentative
        public ActionResult Index()
        {
            var salesRepresentatives = _db.GetAllSalesRepresentatives();
            return View(salesRepresentatives);
        }

        public ActionResult SalesRepresentativeForm()
        {
            var workRoutes = _db.GetAllWorkRoutess();

            var viewModel = new SalesRepresentativeViewModel()
            {
                workRoutes = workRoutes
            };

            return View(viewModel);
        }

        public ActionResult SalesRepresentativeDetails(int? id)
        {
            var salesRepresentative = _db.GetSalesRepresentativeById(id);
            var workRoutes = _db.GetAllWorkRoutess();

            if (salesRepresentative == null)
            {
                return HttpNotFound();
            }

            var viewModel = new SalesRepresentativeViewModel()
            {
                SalesRepresentative = salesRepresentative,
                workRoutes = workRoutes
            };

            return View(viewModel);
        }

        public ActionResult Edit(int? id)
        {
            var salesRepresentative = _db.GetSalesRepresentativeById(id);
            var workRoutes = _db.GetAllWorkRoutess();

            if (salesRepresentative == null)
            {
                return HttpNotFound();
            }

            var viewModel = new SalesRepresentativeViewModel()
            {
                SalesRepresentative = salesRepresentative,
                workRoutes = workRoutes
            };

            return View(viewModel);
        }

      

        [HttpPost]
        public ActionResult Edit(SalesRepresentativeViewModel salesRepresentativeViewModel)
        {
            if(ModelState.IsValid)
            {
                _db.UpdateSalesRepresentative(salesRepresentativeViewModel.SalesRepresentative);
            }

            return RedirectToAction("Index","SalesRepresentative");
        }


        public ActionResult Delete(int? id)
        {
            var salesRepresentative = _db.GetSalesRepresentativeById(id);
            var workRoutes = _db.GetAllWorkRoutess();

            if (salesRepresentative == null)
            {
                return HttpNotFound();
            }

            var viewModel = new SalesRepresentativeViewModel()
            {
                SalesRepresentative = salesRepresentative,
                workRoutes = workRoutes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Delete(SalesRepresentativeViewModel salesRepresentativeViewModel)
        {
            _db.RemoveSalesRepresentative(salesRepresentativeViewModel.SalesRepresentative.Id);
            return RedirectToAction("Index", "SalesRepresentative");
        }


        [HttpPost]
        public ActionResult Create(SalesRepresentativeViewModel viewModel)
        {
           
            _db.AddSalesRepresentative(viewModel.SalesRepresentative);                        
            return RedirectToAction("Index", "SalesRepresentative");

        }
    }
}