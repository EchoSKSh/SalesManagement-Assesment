using SalesManagement.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagement.UI.ViewModel
{
    public class SalesRepresentativeViewModel
    {
        public IEnumerable<WorkRoute> workRoutes { get; set; }
        public SalesRepresentative SalesRepresentative { get; set; }

    }
}