using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Economy.Models
{
    public class Owner
    {
        public int ownerID { get; set; }

        public string post { get; set; }
        public string mobile { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
