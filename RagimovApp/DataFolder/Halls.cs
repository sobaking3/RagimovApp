//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RagimovApp.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Halls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Halls()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int IdHall { get; set; }
        public string HallName { get; set; }
        public int IdPlaceStatus { get; set; }
    
        public virtual PlaceStatus PlaceStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}