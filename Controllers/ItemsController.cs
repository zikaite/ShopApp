using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApp.Data;
using ShopApp.Models;
using ShopApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Controllers
{
    public class ItemsController : Controller
    {
        private DataContext _context;

        public ItemsController(DataContext context)
        {
            _context = context;
        }       
        public IActionResult Index()
        {
            List<Shop> itemsShop = _context.Shops.Include(c => c.Items).ToList();
            List<Item> items = _context.Items.ToList();
            return View(items);
        }
        public IActionResult Add()
        { 
            var addItem = new AddItem()
            {
                Item = new Item(),
                AllShops = _context.Shops.ToList(),
                Tags =_context.Tags.ToList(),
            };
           
            return View(addItem);
        }

        [HttpPost]
        public IActionResult Add(AddItem addItem)
        {
           if (!ModelState.IsValid)
            {
                addItem.AllShops = _context.Shops.ToList();
                return View(addItem);
            }

            _context.Items.Add(addItem.Item);
            _context.SaveChanges();

            foreach (var tagId in addItem.SelectedTagIds)
            {
                _context.ItemTags.Add(new ItemTag()
                {
                    TagId = tagId,
                    ItemId = addItem.Item.Id
                });
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = _context.Items.Find(id);
            _context.Items.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var addItem = new AddItem()
            {
                Item = _context.Items.Find(id),               
                Tags = _context.Tags.ToList(),
                AllShops = _context.Shops.ToList()
            };
            
            return View(addItem);
        }

        [HttpPost]
        public IActionResult Edit(AddItem addItem)
        {
            
            List <ItemTag> itemTags = _context.ItemTags.Where(c => c.ItemId == addItem.Item.Id).ToList();
            //_context.ItemTags.RemoveRange(itemTags);
            foreach (var item in itemTags)
            {
                _context.Remove(item);
            }
            _context.SaveChanges();
            _context.SaveChanges();
            _context.Items.Update(addItem.Item);
            _context.SaveChanges();

            foreach (var tagId in addItem.SelectedTagIds)
            {
                _context.ItemTags.Add(new ItemTag()
                {
                    TagId = tagId,
                    ItemId = addItem.Item.Id
                });
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }

    }    
}
