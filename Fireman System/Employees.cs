//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fireman_Systemn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string rank { get; set; }
        public string home_address { get; set; }
        public Nullable<int> personal_phone_number { get; set; }
        public string email { get; set; }
        public int number_of_answered_cases { get; set; }
        public Nullable<int> choosen_team { get; set; }
    
        public virtual Teams Teams { get; set; }
    }
}
