using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.BOL
{
    public class SalesRepresentative
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int TelephoneNumber { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime? JoinedDate { get; set; }

        public string Comment { get; set; }

        [Required]
        [Display(Name = "Work Route")]
        public int WorkRouteId { get; set; }

        public WorkRoute WorkRoute { get; set; }






    }
}
