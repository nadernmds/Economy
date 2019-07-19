using System.Collections.Generic;

namespace Economy.Models
{
    public class ProjectType
    {
        public int projectTypeID { get; set; }
        public string typeName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}