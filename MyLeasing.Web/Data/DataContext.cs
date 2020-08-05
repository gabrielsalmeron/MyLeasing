﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;
 
namespace MyLeasing.Web.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
            public DbSet<Contract> Contracts {get; set; }
            public DbSet<Lessee> Lessees { get; set; }
            public DbSet<Owner> Owners { get; set; }
            public DbSet<Property> properties { get; set; }
            public DbSet<PropertyImage> PropertyImages { get; set; }
            public DbSet<PropertyType> PropertyTypes { get; set; }



    }
}