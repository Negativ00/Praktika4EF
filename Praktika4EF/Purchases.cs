//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika4EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchases
    {
        public int ID_Purchase { get; set; }
        public string PurchaseName { get; set; }
        public int PurchasePrice { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<int> Store_ID { get; set; }
    
        public virtual Customers Customers {private get; set; }
        public virtual Store Store {private get; set; }
    }
}
