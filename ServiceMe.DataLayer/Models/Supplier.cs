using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
    }
}
