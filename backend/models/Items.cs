using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackathon.project.HackathonProject.backend.models
{
    public class Items
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public int LocationID { get; set; }
        public string UnitOfMeasure { get; set; }
        public int CurrentStock { get; set; }
        public int ReorderPoint { get; set; }
        public int IsActive { get; set; }
        public string ImageURL { get; set; }
        public double UnitCost { get; set; }
        public int Capacity { get; set; }
    }
}