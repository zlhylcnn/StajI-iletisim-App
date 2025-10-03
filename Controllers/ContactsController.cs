using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajIletisimApp.Data;
using StajIletisimApp.Models;

namespace StajIletisimApp.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Create formu
        public IActionResult Create()
        {
            ViewBag.Departments = new List<string> { "Muhasebe", "Teknik Destek", "İnsan Kaynakları" };
            return View();
        }

        // POST: Form gönderimi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                TempData["Success"] = "Başvuru başarıyla gönderildi!";
                return RedirectToAction("Create");
            }

            ViewBag.Departments = new List<string> { "Muhasebe", "Teknik Destek", "İnsan Kaynakları" };
            return View(contact);
        }
    }
}
