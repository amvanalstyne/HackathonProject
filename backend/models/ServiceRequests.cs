using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackathon.project.HackathonProject.backend.models
{
    public class ServiceRequests
    {
        public int ServiceID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int LocationID { get; set; }
        public string Description { get; set; }
        public string Urgency { get; set; } 
        public string Status { get; set; }
        public string RequestTimeStamp { get; set; }
        public string FinishedTimeStamp { get; set; }
    }
}