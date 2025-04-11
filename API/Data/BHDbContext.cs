using Microsoft.EntityFrameworkCore;
using WebsiteBanHang.Entities;

namespace API.Data
{
    public class BHDbContext : DbContext
    {
        public BHDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected BHDbContext()
        //{
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data
            //product
            modelBuilder.Entity<Product>().HasData( new Product
            {
                Id = 1,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Dc Versus Marvel Omnibus",
                Description = "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?",
                ImageUrl = "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg",
                Price = 125,
                Qty = 10,
                CategoryId = 1
            });
            // User
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "a",
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "b",
            });
            // Giỏ Hàng cart
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1,
            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2,
            });
            // danh mục sản phẩm ProductCategory
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Comic",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Electronic",
            });
        }
    
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
