namespace Economy.Models
{
    public class CompanyUser
    {
        public int companyUserID { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }


    }
}