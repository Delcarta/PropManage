//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageProps.codeLogic.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenceRequest
    {
        public int RequestID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string RequestDetails { get; set; }
        public int UserID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> ResidentID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public bool IsClosed { get; set; }
    }
}
