//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class cruises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cruises()
        {
            this.cruise_offers = new HashSet<cruise_offers>();
        }
    
        public int cruise_id { get; set; }
        public string cruise_name { get; set; }
        public string cruise_information { get; set; }
        public int cruise_operator { get; set; }
        public int cruise_ship { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cruise_offers> cruise_offers { get; set; }
        public virtual operators operators { get; set; }
        public virtual ships ships { get; set; }
    }
}