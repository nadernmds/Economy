using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Economy.Models
{
    public class UserGroup
    {
        public int userGroupId { get; set; }
        public string groupName { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
