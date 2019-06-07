using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.BOL
{
    public class WorkRoute
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Work Route")]
        public string Name { get; set; }

    }
}
