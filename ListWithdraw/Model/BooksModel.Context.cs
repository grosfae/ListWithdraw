﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BooksShopEntities : DbContext
    {
        public BooksShopEntities()
            : base("name=BooksShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookType> BookType { get; set; }
        public virtual DbSet<Maker> Maker { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}