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
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
