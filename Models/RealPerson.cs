using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Economy.Models
{
    public class RealPerson
    {
        public int realPersonID { get; set; }
        public string post { get; set; }
        public string nationalCode { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string skills { get; set; }
        public string education { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();

    }
}
