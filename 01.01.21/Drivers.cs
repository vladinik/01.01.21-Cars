//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gibdd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drivers()
        {
            this.Licences = new HashSet<Licences>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int PassportSerial { get; set; }
        public int PassportNumber { get; set; }
        public int Postcode { get; set; }
        public string Address { get; set; }
        public string AddressLife { get; set; }
        public string Company { get; set; }
        public string Jobname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licences> Licences { get; set; }
    }
}
