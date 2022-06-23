using FoodWebAppCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWebAppInfrastructure.Data
{
    public class FoodWebDbContext:DbContext
    {
        public FoodWebDbContext(DbContextOptions<FoodWebDbContext> option) : base(option)
        {

        }

        public DbSet<Customer> Customer { get; set; }
    }
}
