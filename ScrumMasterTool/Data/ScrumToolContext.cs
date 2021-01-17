using Microsoft.EntityFrameworkCore;
using ScrumMasterTool.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumMasterTool.Data
{
    public class ScrumToolContext : DbContext
    {
        public ScrumToolContext(DbContextOptions<ScrumToolContext> options) : base(options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Skill> Skills { get; set; }

        //control mapping between Entities and DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
