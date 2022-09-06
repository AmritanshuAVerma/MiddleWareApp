using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiddleWareApp.Model;

namespace MiddleWareApp.Data
{
    public class MiddleWareAppContext : DbContext
    {
        public MiddleWareAppContext (DbContextOptions<MiddleWareAppContext> options)
            : base(options)
        {
        }

        public DbSet<MiddleWareApp.Model.Employee> Employee { get; set; } = default!;
        public DbSet<MiddleWareApp.Model.ErrorModel> ErrorModel { get; set; } = default!;
    }
}
