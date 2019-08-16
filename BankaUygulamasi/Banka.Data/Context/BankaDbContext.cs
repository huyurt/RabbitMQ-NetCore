using Banka.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Data.Context
{
    public class BankaDbContext : DbContext
    {
        public BankaDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hesap> Hesaps { get; set; }
    }
}
