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
    
    public partial class flights
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public flights()
        {
            this.tour_offers = new HashSet<tour_offers>();
            this.tour_offers1 = new HashSet<tour_offers>();
        }
    
        public int flight_id { get; set; }
        public int flight_airplane { get; set; }
        public string flight_departure_airport { get; set; }
        public System.DateTime flight_departure_date { get; set; }
        public System.TimeSpan flight_departure_time { get; set; }
        public string flight_landing_airport { get; set; }
        public System.DateTime flight_landing_date { get; set; }
        public System.TimeSpan flight_landing_time { get; set; }
    
        public virtual airplanes airplanes { get; set; }
        public virtual airports airports { get; set; }
        public virtual airports airports1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tour_offers> tour_offers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tour_offers> tour_offers1 { get; set; }
    }
}
