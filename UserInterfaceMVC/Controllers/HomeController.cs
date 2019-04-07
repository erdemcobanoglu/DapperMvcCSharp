using EntitiesLayer;
using EntitiesLayer.SqlQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterfaceMVC.Models;

namespace UserInterfaceMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            GetCustomer();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public List<Customer> GetCustomer()
        {
            // add =>  using UserInterfaceMVC.Models;
            var customerResult = MvcDbHelper.Repository.GetAllItems<Customer>(QueryWarehouse.Customer.GetAll).ToList();
            return customerResult;
        } 
        public void GetAccount()
        {
            var accountResult = MvcDbHelper.Repository.GetAllItems<Account>(QueryWarehouse.Account.GetAll).ToList();
        }
        public void GetCity()
        {
            var cityResult = MvcDbHelper.Repository.GetAllItems<City>(QueryWarehouse.City.GetAll).ToList();
        }
        public void GetCountry()
        {
            var countryResult = MvcDbHelper.Repository.GetAllItems<Country>(QueryWarehouse.Country.GetAll).ToList();
        }

        #region Partial Views
        public ActionResult _partialCustomerList()
        {
            return View(GetCustomer());
        }
        #endregion


        // First Create
        #region Views
        //Get işlemi sayfayı buradan çekicek
        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }
        // Post işlemi kaydederken buraya girecek verimiz
        [HttpPost]
        public ActionResult CreateCustomer(Customer model)
        {
            return View();
        }
        #endregion
    }
}