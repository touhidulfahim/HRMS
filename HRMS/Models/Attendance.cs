using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public string Note { get; set; }
    }
}