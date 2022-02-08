using CrudSwag.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CrudSwag.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Interaction> Interaction { get; set; }

    }
}
