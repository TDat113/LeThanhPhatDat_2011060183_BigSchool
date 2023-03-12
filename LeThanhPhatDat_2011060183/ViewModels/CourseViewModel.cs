﻿using LeThanhPhatDat_2011060183.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThanhPhatDat_2011060183.ViewModels
{
    public class CourseViewModel : Controller
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Category { get; set; }
        public IEnumerable<Category>Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0}{1}",Date,Time));
        }
        // GET: CourseViewModel
       
    }
}