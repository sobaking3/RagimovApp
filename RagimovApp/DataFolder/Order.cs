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
    
    public partial class Order
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public string NumberOrder { get; set; }
        public System.DateTime DateOrder { get; set; }
        public int IdStatusOrder { get; set; }
        public decimal PriceOrder { get; set; }
        public int IdProduct { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
    }
}
