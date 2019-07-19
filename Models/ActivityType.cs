using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Economy.Models
{
    public class ActivityType
    {
        [Key]
        public int activtyTypeID { get; set; }
        public string type { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}