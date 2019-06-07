using SalesManagement.BOL;
using SalesManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    public class SalesManagementBll
    {
        private SalesManagementDb _db;

        public SalesManagementBll()
        {
            _db = new SalesManagementDb();
        }

        public IEnumerable<SalesRepresentative> GetAllSalesRepresentatives()
        {
            return _db.GetAllSalesRepresentative();
        }
       
        public void AddSalesRepresentative(SalesRepresentative salesRepresentative)
        {
            _db.AddSalesRepresentative(salesRepresentative);
        }

        public SalesRepresentative GetSalesRepresentativeById(int? id)
        {
            return _db.GetSalesRepresentativeById(id);
        }

        public void UpdateSalesRepresentative(SalesRepresentative salesRepresentative)
        {
            _db.updateSalesRepresentative(salesRepresentative);
        }

        public void RemoveSalesRepresentative(int? id)
        {
            _db.RemoveSalesRepresentative(id);
        }

        public IEnumerable<WorkRoute> GetAllWorkRoutess()
        {
            return _db.GetAllWorkRoutes();
        }

        public void AddWorkRoute(WorkRoute workRoute)
        {
            _db.AddWorkRoute(workRoute);
        }

        public WorkRoute GetWorkRouteById(int? id)
        {
            return _db.GetWorkRouteById(id);
        }

        public void UpdateWorkRoute(WorkRoute workRoute)
        {
            _db.updateWorkRoute(workRoute);
        }

        public void RemoveWorkRoute(int? id)
        {
            _db.RemoveWorkRoute(id);
        }
    }
}
