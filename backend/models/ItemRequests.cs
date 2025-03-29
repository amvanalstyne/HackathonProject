using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackathon.project.HackathonProject.backend.models
{
    public class ItemRequests
    {
        public int RequestID { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public string Status { get; set; }
        public string RequestTimeStamp { get; set; }
        public string FulfilledTimeStamp { get; set; }
        public string Message { get; set; }
    }
}