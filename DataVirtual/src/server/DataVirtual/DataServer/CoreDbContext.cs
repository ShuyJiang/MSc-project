using DataServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer
{
    public class CoreDbContext : DbContext
    {
        public virtual DbSet<Chemical> Chemical { get; set; } //Create an entity class and add it to the Context
        public virtual DbSet<Study> Study { set; get; }
        public virtual DbSet<Observation> Observation { set; get; }
        public virtual DbSet<DoseResp> DoseResp { set; get; }

        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }
    }
}
