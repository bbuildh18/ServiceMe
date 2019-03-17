using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class ItemCategory
    {
        [Key]
        public int CatCode { get; set; }
        public string CatName { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
