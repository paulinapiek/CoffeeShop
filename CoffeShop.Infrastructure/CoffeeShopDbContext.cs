﻿using CoffeeShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CoffeeShop.Infrastructure
{
    public class CoffeeShopDbContext : IdentityDbContext //heritate after  IdentityDbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem>ShoppingCartItems { get; set; }

      
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //seed data after creating  add-migration InitialCreate and override 
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                 new Product { Id = 1, Name = "Americano", Detail = "The Americano coffee is a classic espresso-based drink that is simple yet satisfying. It is made by adding hot water to a shot of espresso, which dilutes the intensity and results in a rich, bold coffee with a smooth finish. This versatile drink can be enjoyed on its own or with a splash of cream, making it a popular choice for coffee lovers everywhere. Whether you need a pick-me-up in the morning or a midday boost, the Americano is a dependable choice that never fails to deliver.", Price = 25, IsTrendingProduct = false, ImageUrl = "https://i.imgur.com/VFHlez3.jpeg" },
                    new Product { Id = 2, Name = "Cortado", Detail = "Cortado coffee is a traditional Spanish coffee beverage that has gained popularity worldwide. It is a smooth and creamy coffee that combines equal parts of espresso and warm milk, creating a perfect balance of intense coffee flavor and rich creaminess. This coffee is perfect for coffee lovers who want a bit of sweetness in their coffee without sacrificing its robust flavor. Cortado coffee is made using high-quality espresso beans, freshly brewed and combined with steamed milk to create a velvety, smooth and flavorful coffee. Whether you are a coffee aficionado or a coffee lover, Cortado coffee is the perfect coffee to start your day with or to enjoy in the afternoon. Try our Cortado coffee today and experience the unique and satisfying taste of this traditional Spanish coffee beverage.", Price = 25, IsTrendingProduct = true, ImageUrl = "https://i.imgur.com/crAMHyg.jpeg" },
                    new Product { Id = 3, Name = "Mocha", Detail = "Mocha coffee is a rich and creamy blend that combines the bold flavor of coffee with the sweetness of chocolate. This delectable drink is perfect for those who love the taste of chocolate but also enjoy a good coffee. Mocha coffee is made with a shot of espresso, steamed milk, and chocolate syrup. The result is a smooth and creamy drink with a sweet, chocolatey taste and a strong coffee finish. Whether you are looking for a sweet and indulgent treat or a pick-me-up in the morning, Mocha coffee is sure to satisfy your cravings. Get your fix of this delicious drink today and experience the perfect marriage of coffee and chocolate!", Price = 22, IsTrendingProduct = false, ImageUrl = "https://i.imgur.com/P133sWJ.jpeg" },
                    new Product { Id = 4, Name = "Macchiato", Detail = "Macchiato Coffee is a classic espresso-based beverage with a rich, creamy flavor and a smooth, velvety texture. Made from high-quality, hand-selected coffee beans, this drink is the perfect pick-me-up for coffee lovers who want a strong, bold taste without the bitterness or harshness of traditional espresso. With a layer of dense, frothed milk that sits on top of the shot of espresso, the Macchiato Coffee is the perfect balance of bold coffee flavor and creamy sweetness. Whether you're a busy professional in need of a morning boost, or an espresso aficionado seeking a more refined coffee experience, the Macchiato Coffee is the ultimate choice for anyone who loves coffee. So why wait? Visit our online coffee store today and try a Macchiato Coffee today!", Price = 15, IsTrendingProduct = true, ImageUrl = "https://i.imgur.com/tbbLEME.jpeg" },
                    new Product { Id = 5, Name = "Flat White", Detail = "Flat White Coffee is a classic espresso-based beverage that is a staple in coffee shops all over the world. This smooth and creamy coffee is made with perfectly pulled shots of espresso, topped with velvety steamed milk and a thin layer of microfoam. This gives the Flat White its signature smooth and creamy texture and a rich, coffee flavor that is balanced by the sweetness of the milk. The Flat White is a perfect coffee for those who love a strong coffee taste with a hint of sweetness. Whether you are a coffee aficionado or just looking for a delicious coffee to start your day, a Flat White from our store is the perfect choice!", Price = 18, IsTrendingProduct = true, ImageUrl = "https://i.imgur.com/NjFqRND.jpeg" },
                    new Product { Id = 6, Name = "Decaf", Detail = "Decaf Coffee, also known as decaffeinated coffee, is a coffee beverage that has had the majority of its caffeine content removed. It is a perfect option for those who enjoy the taste and aroma of coffee, but want to avoid the stimulating effects of caffeine. Decaf coffee is made from 100% Arabica beans, which are carefully roasted to bring out their natural sweetness and rich flavor. Whether you're a coffee aficionado or just looking for a comforting cup of joe, decaf coffee is the perfect choice. It offers all the delicious taste of regular coffee, without the caffeine jitters, making it an ideal choice for late-night sipping, morning or afternoon pick-me-ups, or simply whenever you want to relax and enjoy a cup of coffee. So why wait? Treat yourself to a delicious cup of decaf coffee today and enjoy the taste of coffee, without the caffeine.", Price = 25, IsTrendingProduct = false, ImageUrl = "https://i.imgur.com/ltycy47.jpeg" },
                    new Product { Id = 7, Name = "Irish Coffee", Detail = "Irish coffee is a warm, comforting drink that combines the bold flavor of coffee with the smooth sweetness of Irish whiskey and a touch of cream. Our version of this classic cocktail is made with rich, bold coffee and the finest Irish whiskey for a perfect balance of flavors. The cream is gently whipped to a smooth consistency and poured over the coffee, creating a luxurious, creamy layer that balances the whiskey’s warmth. Whether you’re looking for a cozy drink on a cold day or a fun nightcap after a night out, Irish coffee is a perfect choice. Order yours today and experience the perfect blend of coffee and whiskey.", Price = 15, IsTrendingProduct = true, ImageUrl = "https://i.imgur.com/R1QoGjI.jpeg" },
                    new Product { Id = 8, Name = "Iced Coffee", Detail = "Iced coffee is a refreshing and delicious way to enjoy your coffee, perfect for hot summer days or for anyone looking for a cool pick-me-up. Our iced coffee is made with high-quality, freshly brewed coffee, which is then chilled and served over ice. We use only the finest coffee beans, expertly roasted to bring out their rich, full-bodied flavor, ensuring that every sip is a treat. Our iced coffee is available in a variety of flavors, including classic black, vanilla, caramel, and mocha, making it the perfect choice for coffee lovers of all tastes. So why wait? Treat yourself to a cold, refreshing glass of iced coffee today!", Price = 13, IsTrendingProduct = false, ImageUrl = "https://i.imgur.com/VaMl903.jpeg" }

                );



            _ = modelBuilder.Entity<IdentityUser>().HasData(
               new IdentityUser()
               {
                   Id = "7c75c593-4454-4263-8959-9c419f94e7fc",
                   UserName = "testadmin@gmail.com",
                   NormalizedUserName = "TESTADMIN@GMAIL.COM",
                   Email = "testadmin@gmail.com",
                   NormalizedEmail = "TESTADMIN@GMAIL.COM",
                   EmailConfirmed = false,
                   PasswordHash = "AQAAAAIAAYagAAAAEBBICR9Vv3IsSs1SziaI9MY52RhRxhAqoCDhGKV/DZ35VrhiQfeyKuGmq+eY4U+z/g==",
                   SecurityStamp = "V7LYP5BOZSODL7ZNRVQXQRV72NNG2BZ4",
                   ConcurrencyStamp = "433d2ef8-f135-481f-a694-4d1e1883499e",
                   PhoneNumber = null,
                   PhoneNumberConfirmed = false,
                   TwoFactorEnabled = false,
                   LockoutEnd = null,
                   LockoutEnabled = true,
                   AccessFailedCount = 0
               },
            new IdentityUser()
            {
                Id = "3987099b-3a5d-4cd0-904d-12a6d1f801bb",
                UserName = "testuser@gmail.com",
                NormalizedUserName = "TESTUSER@GMAIL.COM",
                Email = "testuser@gmail.com",
                NormalizedEmail = "TESTUSER@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAIAAYagAAAAEKF+gOXmZ8vIRbdG/MCOM0EH+cWvootd03tO51R4bqLajN6kWR+AX/szl7fc+hJnwA==",
                SecurityStamp = "FKVYI6UAIYDTXJV6OMMINLSSTNE6YCJK",
                ConcurrencyStamp = "4882f25f-fb8d-47cf-a489-54def41c61e6",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }
            );



            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "1", Name = "Admin" });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
             new IdentityUserRole<string>() { UserId = "7c75c593-4454-4263-8959-9c419f94e7fc", RoleId = "1" });

        }
        //insert data into the projects table add another migration -SeedProductsTable and then update the database with new migration 
        //update-database
    }
}
