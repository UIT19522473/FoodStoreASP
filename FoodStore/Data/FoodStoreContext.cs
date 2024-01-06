using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodStore.Models;

namespace FoodStore.Data
{
    public class FoodStoreContext : DbContext
    {
        public FoodStoreContext (DbContextOptions<FoodStoreContext> options)
            : base(options)
        {
        }

        public DbSet<FoodStore.Models.Customer> Customer { get; set; } = default!;

        public DbSet<FoodStore.Models.Category>? Category { get; set; }

        public DbSet<FoodStore.Models.Dish>? Dish { get; set; }

        public DbSet<FoodStore.Models.Order>? Order { get; set; }

        public DbSet<FoodStore.Models.OrderDetail>? OrderDetail { get; set; }

        public DbSet<FoodStore.Models.Rating>? Rating { get; set; }
    }
}
