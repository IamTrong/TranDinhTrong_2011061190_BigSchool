﻿using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web.Mvc;
using TranDinhTrong_2011061190.Models;
using System.Data;
using System.Data.Entity;

namespace TranDinhTrong_2011061190.Controllers
{
    public class HomeController : Controller
    {

        public ApplicationDbContext _dbcontext;
       public HomeController ()
        {
            _dbcontext = new ApplicationDbContext ();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbcontext.Courses
            .Include(c => c.Lecturer)
            .Include(c => c.Category)
            .Where(c => c.DateTime > DateTime.Now);
            return View(upcommingCourses);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}