using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQLtoJSON.Models
{
    public class EmployeeViewModel
    {

        /*public int dep_id { get; set; }*/
        public string dep_name { get; set; }

        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public Nullable<int> emp_sal { get; set; }
        public Nullable<int> emp_dept_fk { get; set; }


    }
}