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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Companies = new HashSet<Company>();
            this.WorkOrders = new HashSet<WorkOrder>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> IsOwner { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public Nullable<bool> IsResident { get; set; }
        public Nullable<bool> IsVendor { get; set; }
        public string EmployeeOf { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}