using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactsController : Controller
    {
        private IGenericRepository _repo;

        public ContactsController(IGenericRepository repo)
        {
            _repo = repo;
        }
        
        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = _repo.Query<Contact>();
            return View(contacts);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            var contact = _repo.Find<Contact>(id);
            return View();
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _repo.Add<Contact>(contact);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            var contact = _repo.Find<Contact>(id);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var original = _repo.Find<Contact>(contact.Id);
                original.FirstName = contact.FirstName;
                original.LastName = contact.LastName;
                original.Birthday = contact.Birthday;
                original.PhoneNumber = contact.PhoneNumber;
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            var contact = _repo.Find<Contact>(id);
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.Delete<Contact>(id);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
