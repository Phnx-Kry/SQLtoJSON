//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLtoJSON.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tble_employee
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public Nullable<int> emp_sal { get; set; }
        public Nullable<int> emp_dept_fk { get; set; }
    
        public virtual depart depart { get; set; }
    }
}
