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
    
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.Residents = new HashSet<Resident>();
        }
    
        public int UnitID { get; set; }
        public int UnitLotNum { get; set; }
        public string UnitAddress1 { get; set; }
        public string UnitAddress2 { get; set; }
        public string Zip { get; set; }
        public int PropertyID { get; set; }
    
        public virtual Property Property { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resident> Residents { get; set; }
    }
}