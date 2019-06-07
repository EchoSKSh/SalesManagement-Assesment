using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.BOL
{
    public class Db:DbContext
    {

        public DbSet<SalesRepresentative> SalesRepresentatives { get; set; }
        public DbSet<WorkRoute> WorkRoutes { get; set; }
    }
}
