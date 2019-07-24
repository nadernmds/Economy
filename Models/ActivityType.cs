using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Economy.Models
{
    public class ActivityType
    {
        public ActivityType()
        {
            Companies = new HashSet<Company>();
        }
        [Key]
        public int activtyTypeID { get; set; }
        public string type { get; set; }
        [JsonIgnore]
        public virtual ICollection<Company> Companies { get; set; }
    }
}