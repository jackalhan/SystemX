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
    
    public partial class LU_EstateType
    {
        public LU_EstateType()
        {
            this.Estate = new HashSet<Estate>();
        }
    
        public int Seq { get; set; }
        public string TypeName { get; set; }
        public int Status { get; set; }
        public System.DateTime InsertedTime { get; set; }
        public string InsertedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ICollection<Estate> Estate { get; set; }
        public virtual Message Message { get; set; }
    }
}