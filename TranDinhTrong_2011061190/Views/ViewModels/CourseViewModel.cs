using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranDinhTrong_2011061190.Models;

namespace TranDinhTrong_2011061190.Views.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("0","1", Date ,Time));
        }
    }
}