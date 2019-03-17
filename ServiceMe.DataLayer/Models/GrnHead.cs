using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class GrnHead
    {
        [Key]
        public int GrnHeadID{ get; set; }
        public IList<GrnDetail> GrnDetails { get; set; }
    }
}
