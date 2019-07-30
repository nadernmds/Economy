using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Economy.Models
{
    public class Company
    {
        [Key]
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string startDate { get; set; }
        public string nationalCode { get; set; }
        public int? personnelCount { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new HashSet<CompanyUser>();
        public virtual ActivityType ActivityType { get; set; }
        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();
        public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
    }
}
