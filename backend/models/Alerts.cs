using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackathon.project.HackathonProject.backend.models
{
    public class Alerts
    {
        public int AlertID { get; set; }
        public int UserID { get; set; }
        public string AlertMessage { get; set; }
        public string AlertTime { get; set; }
        public int IsRead { get; set; }
        public string RelatedEntityType { get; set; }

    }
}