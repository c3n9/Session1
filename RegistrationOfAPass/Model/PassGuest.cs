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
    
    public partial class PassGuest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patromic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string PassportSeria { get; set; }
        public string PassportNumber { get; set; }
        public byte[] Photo { get; set; }
        public int PassId { get; set; }
    
        public virtual Pass Pass { get; set; }
    }
}
