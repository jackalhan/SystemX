//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.City = new HashSet<City>();
        }
    
        public int Seq { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
        public string InsertedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ICollection<City> City { get; set; }
    }
}
