using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VUB_MVC.Models;

    public class VUB_MVCDbContext : DbContext
    {
        public VUB_MVCDbContext (DbContextOptions<VUB_MVCDbContext> options)
            : base(options)
        {
        }

        public DbSet<VUB_MVC.Models.Book> Books { get; set; } = default!;

        public DbSet<VUB_MVC.Models.BookType>? Types { get; set; }
    }
