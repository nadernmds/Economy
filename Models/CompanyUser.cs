namespace Economy.Models
{
    public class CompanyUser
    {
        public int companyUserID { get; set; }
        public int companyID { get; set; }
        public virtual Company Company { get; set; }
        public int userID { get; set; }
        public virtual User User { get; set; }

    }
}