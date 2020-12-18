using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree userTotal)
        {
            if (ModelState.IsValid)
            {


                if (string.IsNullOrEmpty(userTotal.FirstName) || string.IsNullOrEmpty(userTotal.LastName) || string.IsNullOrEmpty(userTotal.EmailAddress) ||
                 string.IsNullOrEmpty(userTotal.CarMake) || string.IsNullOrEmpty(userTotal.CarModel) || string.IsNullOrEmpty(Convert.ToString(userTotal.DUI)) || 
                 string.IsNullOrEmpty(Convert.ToString(userTotal.SpeedingTickets)) || string.IsNullOrEmpty(Convert.ToString(userTotal.CoverageType)))
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                else
                {
                    using (InsuranceEntities db = new InsuranceEntities())
                    {
                        

                        double quote = 50;
                        int age = (DateTime.Now.Year - userTotal.DateOfBirth.Year);
                        if (age <= 18)
                        {
                            quote += 100;
                        }
                        if (age > 18 && age < 26)
                        {
                            quote += 50;
                        }
                        if (age > 25)
                        {
                            quote += 25;
                        }
                        if (userTotal.CarYear < 2000)
                        {
                            quote += 25;
                        }
                        if (userTotal.CarYear > 2015)
                        {
                            quote += 25;
                        }
                        if (userTotal.CarMake.ToLower() == "porsche")
                        {
                            quote += 25;
                            if (userTotal.CarMake.ToLower() == "911 carrera")
                            {
                                quote += 25;
                            }
                        }
                        quote += (userTotal.SpeedingTickets * 10);
                        if (userTotal.DUI)
                        {
                            quote += (quote * .25);
                        }
                        if (userTotal.CoverageType)
                        {
                            quote += (quote * .5);
                        }
                        userTotal.Quote = (decimal)quote;
                        
                    }
                }

                db.Insurees.Add(userTotal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(userTotal);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
