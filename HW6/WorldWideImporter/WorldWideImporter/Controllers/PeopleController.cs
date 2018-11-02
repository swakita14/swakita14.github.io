using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorldWideImporter.Models;
using WorldWideImporter.Models.CompanyViewModel;

namespace WorldWideImporter.Controllers
{
    public class PeopleController : Controller
    {
        /// <summary>
        /// This is the context file that connects my db to the project
        /// </summary>
        private WWIContext db = new WWIContext();

        /// <summary>
        /// This searches for the users in the db
        /// </summary>
        /// <param name="search">the string that is entered to look through the db</param>
        /// <returns>a view with a person that matches the query string</returns>
        // GET: People
        public ActionResult Index(String search)
        {
            //Using my View Model
            ViewModel vm = new ViewModel();


            search = Request.QueryString["search"];
            if (search == null || search == "")
            {
                ViewBag.show = false;
                return View();
            }
            else
            {
                ViewBag.show = true;
                return View(db.People.Where(p => p.FullName.Contains(search)).ToList());
            }
        }

        /// <summary>
        /// This retrieves the information concerning the person
        /// </summary>
        /// <param name="id">takes in an id, then matches the person</param>
        /// <returns>the ViewModel with PErson, Customer, and InvoiceLines</returns>
        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            //my viewmodel
            ViewModel vm = new ViewModel();

            //find the person
            vm.Person = db.People.Find(id);

            //if he is a regular person lets not show anymore information
            ViewBag.IsP = false;

            //if he is a primary contact person
            if (vm.Person.Customers2.Count() > 0)
            {
                //lets show the information
                ViewBag.IsP = true;
                int cid = vm.Person.Customers2.FirstOrDefault().CustomerID;
                vm.Customer = db.Customers.Find(cid);

                //find the gross sales
                ViewBag.GrossSales = vm.Customer.Orders.SelectMany(il => il.Invoices).SelectMany(ils => ils.InvoiceLines).Sum(i => i.ExtendedPrice);

                //find the gross profit
                ViewBag.GrossProfit = vm.Customer.Orders.SelectMany(il => il.Invoices).SelectMany(ils => ils.InvoiceLines).Sum(i => i.LineProfit);

                //selects the information on the top ten sales
                vm.InvoiceLine = vm.Customer.Orders.SelectMany(x => x.Invoices)
                                                .SelectMany(i => i.InvoiceLines)
                                                .OrderByDescending(i => i.LineProfit)
                                                .Take(10)
                                                .ToList();

            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

    }
}
