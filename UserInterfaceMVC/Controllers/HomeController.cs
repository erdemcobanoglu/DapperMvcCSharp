﻿using EntitiesLayer;
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

        public void GetCustomer()
        {
            // add =>  using UserInterfaceMVC.Models;
            var customerResult = MvcDbHelper.Repository.GetAllItems<Customer>(QueryWarehouse.Customer.GetAll).ToList();
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
    }
}