using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{   
    public class CustReceiptHead
    {
        [Key]
        public int CustReceiptHeadID { get; set; }
        [ForeignKey("CustID")]
        public int CustID { get; set; }
        public Customer Customer { get; set; }
    }
}
