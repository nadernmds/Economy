using System.Collections.Generic;

namespace Economy.Models
{
    public class User
    {
        public User()
        {
            CompanyUsers = new HashSet<CompanyUser>();
        }
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int? userGroupId { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new HashSet<CompanyUser>();

        public virtual UserGroup UserGroup { get; set; }


    }
}