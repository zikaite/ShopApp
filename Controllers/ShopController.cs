using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApp.Data;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Controllers
{
    public class ShopController : Controller
    {
        private DataContext _context;

        public ShopController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Shop> items = _context.Shops.ToList();
            
            return View(items);
        }

        public IActionResult Add()
        {
            var shop = new Shop();
            return View(shop);
        }

        [HttpPost]
        public IActionResult Add(Shop shop)
        {
            if (!ModelState.IsValid)
            {
                return View(shop);                
            }
            _context.Shops.Add(shop);
            _context.SaveChanges();            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var shop = _context.Items.Find(id);
            _context.Items.Remove(shop);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var shop = _context.Shops.Find(id);
            return View(shop);
        }

        [HttpPost]
        public IActionResult Edit(Shop shop)
        {
            _context.Shops.Update(shop);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
        
    
}
