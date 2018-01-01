using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int CandidateId { get; set; }
        public string Level { get; set; }
        public DateTime Create { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Scheduled { get; set; }
        public string Location { get; set; }
        public int MapId { get; set; }
        public string Status { get; set; }
        public string  Note  { get; set; }
    }
}