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
    
    public partial class tours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tours()
        {
            this.tour_offers = new HashSet<tour_offers>();
        }
    
        public int tour_id { get; set; }
        public string tour_information { get; set; }
        public int tour_number_of_nights { get; set; }
        public int tour_operator { get; set; }
        public int tour_hotel { get; set; }
        public int tour_food { get; set; }
        public int tour_tourists { get; set; }
    
        public virtual food food { get; set; }
        public virtual hotels hotels { get; set; }
        public virtual operators operators { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tour_offers> tour_offers { get; set; }
    }
}
