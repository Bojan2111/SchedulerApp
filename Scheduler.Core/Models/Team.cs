using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Core.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required]
        [StringLength(3)]
        [MinLength(1)]
        [RegularExpression(@"DN3|8{1}")]
        public string? ShiftPattern { get; set; }

        public int CurrentMonth { get; set; }

        public DateTime CurrentStartDate { get; set; }

        public DateTime NextMonthStartDate { get; set; }

        public bool NextMonthStartsWithNight { get; set; }
    }
}
