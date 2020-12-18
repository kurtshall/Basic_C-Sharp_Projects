using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarInsurance.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())  return View();
        }
        [HttpPost]

        public ActionResult GetQuote(string FirstName, string LastName, string EmailAddress, string DateOfBirth, int CarYear, string CarMake,
                                            string CarModel, string DUI, string SpeedingTickets, string Coverage)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress)||
                 string.IsNullOrEmpty(CarMake) || string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(DUI) || string.IsNullOrEmpty(SpeedingTickets) || string.IsNullOrEmpty(Coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var userTotal = new Insuree();

                    userTotal.FirstName = FirstName;
                    userTotal.LastName = LastName;
                    userTotal.EmailAddress = EmailAddress;
                    userTotal.DateOfBirth = Convert.ToDateTime(DateOfBirth);
                    userTotal.CarYear = CarYear;
                    userTotal.CarMake = CarMake;
                    userTotal.CarModel = CarModel;
                    userTotal.DUI = Convert.ToBoolean(DUI);
                    userTotal.SpeedingTickets = Convert.ToInt32(SpeedingTickets);
                    userTotal.CoverageType = Convert.ToBoolean(Coverage);

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
                    db.Insurees.Add(userTotal);
                    db.SaveChanges();

                    return View(userTotal);
                }
            }
        }
    }
}