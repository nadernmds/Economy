using System;

namespace Economy.Models
{
    public class Project
    {
        public int projectID { get; set; }
        public string title { get; set; }
        public string decription { get; set; }
        public int capacity { get; set; }
        public DateTime date { get; set; }
        public int doLenght { get; set; }
        public double ownerInvestment { get; set; }
        public double astanInvestment { get; set; }
        public virtual Company Company { get; set; }
        public virtual ProjectType projectType { get; set; }

    }
}