using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
    }
}
