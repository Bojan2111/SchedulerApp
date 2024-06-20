using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Core.Models
{
    public class Shift
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        [MinLength(1)]
        [RegularExpression(@"D|N|VP|BO|GO|PO{1}")]
        public string? Name { get; set; }
        public int Month { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
