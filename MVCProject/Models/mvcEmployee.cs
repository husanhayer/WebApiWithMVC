using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class mvcEmployee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please Enter your name")]
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<decimal> Salary { get; set; }
    }
}