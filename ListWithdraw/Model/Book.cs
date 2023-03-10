//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListWithdraw.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Id { get; set; }
        public string Artic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Nullable<int> Pages { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Discount { get; set; }
        public int StorageCount { get; set; }
        public byte[] Image { get; set; }
        public int BookTypeId { get; set; }
        public int MakerId { get; set; }
        public int ShipperId { get; set; }
    
        public virtual BookType BookType { get; set; }
        public virtual Maker Maker { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
