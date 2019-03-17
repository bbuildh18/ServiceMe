using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class ItemFac
    {
        [Key]
        public int ItemFacID { get; set; }
        public int ItemID { get; set; }
        public double Qty { get; set; }

    }
}
