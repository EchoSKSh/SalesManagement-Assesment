using SalesManagement.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.DAL
{
    public class SalesManagementDb
    {
        private Db _db;

        public SalesManagementDb()
        {
            _db = new Db();
            
        }

        public IEnumerable<SalesRepresentative> GetAllSalesRepresentative()
        {
            return _db.SalesRepresentatives.Include(m => m.WorkRoute).ToList();
        }      

        public void AddSalesRepresentative(SalesRepresentative salesRepresentative)
        {
            _db.SalesRepresentatives.Add(salesRepresentative);
            Save();
        }

        public SalesRepresentative GetSalesRepresentativeById(int? id)
        {
            return _db.SalesRepresentatives.SingleOrDefault(m => m.Id == id);
        }

        public void updateSalesRepresentative(SalesRepresentative salesRepresentative)
        {
            var salesRepresentativeInDb = _db.SalesRepresentatives.Single(m => m.Id == salesRepresentative.Id);

            salesRepresentativeInDb.Name = salesRepresentative.Name;
            salesRepresentativeInDb.Email = salesRepresentative.Email;
            salesRepresentativeInDb.TelephoneNumber = salesRepresentative.TelephoneNumber;
            salesRepresentativeInDb.JoinedDate = salesRepresentative.JoinedDate;
            salesRepresentativeInDb.WorkRouteId = salesRepresentative.WorkRouteId;
            salesRepresentativeInDb.Comment = salesRepresentative.Comment;

            Save();

        }

        public void RemoveSalesRepresentative(int? id)
        {
            var salesRepresentative = GetSalesRepresentativeById(id);
            _db.SalesRepresentatives.Remove(salesRepresentative);

            Save();
        }

        public IEnumerable<WorkRoute> GetAllWorkRoutes()
        {
            return _db.WorkRoutes.ToList();
        }

        public void AddWorkRoute(WorkRoute workRoute)
        {
            _db.WorkRoutes.Add(workRoute);
            Save();
        }

        public WorkRoute GetWorkRouteById(int? id)
        {
            return _db.WorkRoutes.SingleOrDefault(m => m.Id == id);
        }

        public void updateWorkRoute(WorkRoute workRoute)
        {
            var workRouteInDb = _db.WorkRoutes.Single(m => m.Id == workRoute.Id);

            workRouteInDb.Name = workRoute.Name;
            Save();

        }

        public void RemoveWorkRoute(int? id)
        {
            var workRoute = GetWorkRouteById(id);
            _db.WorkRoutes.Remove(workRoute);

            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
