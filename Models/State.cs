using System.Collections.Generic;

namespace Economy.Models
{
    public class State
    {
        public int stateID { get; set; }
        public string stateName { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}