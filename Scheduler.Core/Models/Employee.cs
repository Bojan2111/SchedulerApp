using System.ComponentModel.DataAnnotations;

namespace Scheduler.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        public int TeamId { get; set; }
        public Team? Team { get; set; }

        public int TeamRoleId { get; set; }
        public TeamRole? TeamRole { get; set; }

        public int MonthsEmployed { get; set; }

        public string? ReligiousHoliday { get; set; }
    }
}
