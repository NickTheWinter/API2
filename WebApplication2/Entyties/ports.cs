//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Entyties
{
    using System;
    using System.Collections.Generic;
    
    public partial class ports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ports()
        {
            this.cruise_offers = new HashSet<cruise_offers>();
            this.cruise_offers1 = new HashSet<cruise_offers>();
        }
    
        public int port_id { get; set; }
        public string port_name { get; set; }
        public int port_city { get; set; }
        public string port_address { get; set; }
        public string port_phone_number { get; set; }
    
        public virtual cities cities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cruise_offers> cruise_offers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cruise_offers> cruise_offers1 { get; set; }
    }
}