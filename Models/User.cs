using System.Collections.Generic;

namespace Economy.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string economyCode { get; set; }
        public string nationalCode { get; set; }

        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }

        public virtual UserGroup UserGroup { get; set; }


    }
}