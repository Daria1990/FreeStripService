using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreeStripService.Model;

namespace FreeStripService.Data
{
    public class AirTransportContext : DbContext
    {
        public AirTransportContext(DbContextOptions<AirTransportContext> options) : base(options)
        {
            Database.EnsureCreated();   
        }

        public DbSet<PlainType> PlainTypes { get; set; }

        public DbSet<PlainModel> PlainModels { get; set; }
    }
}
