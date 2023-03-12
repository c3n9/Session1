//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationOfAPass.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pass()
        {
            this.PassDocument = new HashSet<PassDocument>();
            this.PassGuest = new HashSet<PassGuest>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public string VisitPurpose { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> UserId { get; set; }
        public int PassStatusId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual PassStatus PassStatus { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassDocument> PassDocument { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassGuest> PassGuest { get; set; }
    }
}
