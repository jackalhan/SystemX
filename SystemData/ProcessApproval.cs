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
    
    public partial class ProcessApproval
    {
        public long Seq { get; set; }
        public long CustomerSeq { get; set; }
        public string CorrelationCode { get; set; }
        public byte[] CorrelationCodeSentTime { get; set; }
        public string GeneratedAuthenticationCode { get; set; }
        public string ReceivedAuthenticationCode { get; set; }
        public Nullable<System.DateTime> AuthenticationCodeReceivedTime { get; set; }
        public Nullable<int> StatusSeq { get; set; }
        public Nullable<System.DateTime> InsertedTime { get; set; }
        public string InsertedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> LU_ProcessTypeSeq { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual LU_ProcessType LU_ProcessType { get; set; }
        public virtual Message Message { get; set; }
    }
}