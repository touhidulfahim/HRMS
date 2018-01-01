using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class Attendance
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        [Display(Name = "In Time")]
        public DateTime InTime { get; set; }
        [Display(Name = "Out Time")]
        public DateTime OutTime { get; set; }
        public string Note { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}