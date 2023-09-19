using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Customers.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer cus)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cus);
        }
        private bool CustomerExists(string ID)
        {
            return _context.Customers.Any(e => e.CustomerID == ID);
        }
        public async Task<IActionResult> Edit(string ID)
        {
            if (ID == null)
            {
                return View ("NotFound");
            }
            var customer = await _context.Customers.FindAsync(ID);
            if (customer == null)
            {
                return View ("NotFound");
            }
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string ID, [Bind("CustomerID, CustomerName")] Customer cus)
        {
            if (ID != cus.CustomerID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(cus.CustomerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string ID)
        {
            var cus = await _context.Customers.FindAsync(ID);
            _context.Customers.Remove(cus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //return NotFound()
    }
}