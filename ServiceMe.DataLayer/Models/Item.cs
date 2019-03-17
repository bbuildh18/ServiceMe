using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public bool IsSerialized { get; set; }

        public double UnitPrice { get; set; }

    }
}
