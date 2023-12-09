using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels;

    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options): base(options) { }

        public DbSet<tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels.People> People { get; set; } = default!;
    }
