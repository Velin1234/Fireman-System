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
    
    public partial class Cases
    {
        public int case_id { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public int Address_number { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> Apartment { get; set; }
        public string Case_type { get; set; }
        public string Dangerous_substances_info { get; set; }
        public int Selected_team { get; set; }
        public System.DateTime Date_time_of_case { get; set; }
        public Nullable<System.DateTime> End_date_time_of_case { get; set; }
        public Nullable<double> Used_water_resources { get; set; }
        public Nullable<double> Used_fuel { get; set; }
    
        public virtual Teams Teams { get; set; }
    }
}
