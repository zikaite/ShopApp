using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dtos
{
    public class AddItem
    {
        public Item Item { get; set; }

        public List<Shop> AllShops { get; set; }

        public List<Tag> Tags { get; set; }

        public List<int> SelectedTagIds { get; set; }
    }
}
