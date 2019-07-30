using System.Collections.Generic;

namespace Economy.Models
{
    public class AssetType
    {
        public int assetTypeID { get; set; }
        public string assetType { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}