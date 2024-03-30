﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework;
// Context : Db tabloları ile proje classlarını bağlamak
public class NorthwindContext : DbContext
{
    //bu metot senin projen hangi veri tabanı ile ilişkiyi belirteceğimiz yer
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //burda hangi ve
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=true");
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }


}