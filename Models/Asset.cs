namespace Economy.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string title { get; set; }
        public decimal? emount { get; set; }
        public virtual Company Company { get; set; }
        public int? companyID { get; set; }
        public  virtual RealPerson RealPerson { get; set; }
        public int? realPersonID { get; set; }
        public int? assetTypeID { get; set; }
        public virtual AssetType AssetType { get; set; }
    }
}