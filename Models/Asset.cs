namespace Economy.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string title { get; set; }
        public decimal emount { get; set; }
        public virtual Company Company { get; set; }
    }
}