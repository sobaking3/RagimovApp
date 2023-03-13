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
    
    public partial class WorkerAdress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkerAdress()
        {
            this.CityWorker = new HashSet<CityWorker>();
            this.WorkerInfo = new HashSet<WorkerInfo>();
            this.RegionWorker = new HashSet<RegionWorker>();
            this.StreetWorker = new HashSet<StreetWorker>();
        }
    
        public int IdAdress { get; set; }
        public int IdRegion { get; set; }
        public int IdCity { get; set; }
        public int IdStreet { get; set; }
        public string HomeNumber { get; set; }
        public string AppartmentNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityWorker> CityWorker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkerInfo> WorkerInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionWorker> RegionWorker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StreetWorker> StreetWorker { get; set; }
    }
}
