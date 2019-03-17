using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class ItemFacInv
    {
        [Key]
        public int ItemFacInvID { get; set; }
        public int ItemFacID { get; set; }

    }
}
