using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Tag
    {
        public List<ItemTag> ItemTags { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
