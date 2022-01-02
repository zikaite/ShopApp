using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        public Shop Shop { get; set; }
        [Required]
        public int? ShopId { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;

        public List<ItemTag> ItemTags { get; set; }

    }
}
