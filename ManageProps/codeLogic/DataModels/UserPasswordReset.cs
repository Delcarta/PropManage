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
    
    public partial class UserPasswordReset
    {
        public int UserID { get; set; }
        public System.Guid ResetKey { get; set; }
        public System.DateTime Expiry { get; set; }
    }
}
