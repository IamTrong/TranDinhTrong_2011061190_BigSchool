﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TranDinhTrong_2011061190.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order=1)]
        public ApplicationUser Attendee { get; set;}
        [Key]
        [Column(Order=2)]
        public string  AttendeeId { get; set; } 
    }
}