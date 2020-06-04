using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsDirectory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactsDirectory.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        public ActionResult<IEnumerable<PersonViewModel>> Index()
        {
            var persons = DataProvider();
            return View(persons);
        }

        // GET: Friend/Details/5
        public ActionResult<PersonViewModel> Details(int id)
        {
            var persons = DataProvider();
            foreach (var person in persons)
            {
                if (person.Person_Id == id)
                {
                    return View(person);
                }
            }
            return View(new PersonViewModel());
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Friend/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Friend/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private IEnumerable<PersonViewModel> DataProvider()
        {
            var person = new List<PersonViewModel>
            {
                new PersonViewModel
                {
                    Person_Id = 1,
                    Name = "Sanjay",
                    Contacts = new List<Contact>
                    {
                        new Contact{ Contact_Id = "c0", Type = "phone", Link = "9830 122222"},
                        new Contact{ Contact_Id = "c0", Type = "phone", Link = "9830 122222"}
                    },
                    Adresses = new List<Address>{new Address { Address_Id = "02", Locality = "Hebbal", State = "KA", Country = "IN" } }

                },
                new PersonViewModel
                {
                    Person_Id = 2,
                    Name = "Sanjay",
                    Contacts = new List<Contact>
                    {
                        new Contact{ Contact_Id = "c0", Type = "phone", Link = "9830 122222"},
                        new Contact{ Contact_Id = "c0", Type = "phone", Link = "9830 122222"}
                    },
                    Adresses = new List<Address>{new Address{ Address_Id = "01", Locality="Hebbal", State="KA", Country="IN"} }

                }
            };
            return person;
        }
    }
}