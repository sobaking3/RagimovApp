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
    
    public partial class Staff
    {
        public int IdStaff { get; set; }
        public string LastNameStaff { get; set; }
        public string FirstNameStaff { get; set; }
        public string MiddleNameStaff { get; set; }
        public string NumberPhone { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual User User { get; set; }
    }
}
