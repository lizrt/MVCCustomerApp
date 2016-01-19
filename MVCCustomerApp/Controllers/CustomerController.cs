using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCustomerApp.Models;

namespace MVCCustomerApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private static Customers _customers = new Customers();
        public ActionResult Index()
        {
            return View(_customers._customerList);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerModel custModel)
        {
            _customers.CreateCustomer(custModel);
            return RedirectToAction("Index");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          CustomerModel cust= _customers.GetCustomer(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(CustomerModel cust)
        {
            try
            {
                // TODO: Add update logic here
                _customers.UpdateCustomer(cust);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
