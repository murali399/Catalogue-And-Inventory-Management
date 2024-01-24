using Catalogue.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.InfastructureLayer.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties

            var difficulties = new List<Product>()

            {

                new Product()

                {

                    Id = Guid.Parse("8691edd4-40e2-4c48-b64d-a13dc02109ad"),

                    ProdutcId=145,
                    ProductName="Mobiles",
                    ProductDescription="it is user friendly",
                    ImgUrl="mobile.jpj",
                    Category="Redmi",
                    SubCategory="Redmi7pro"

                },

               new Product()

                {

                    Id = Guid.Parse("defd41d0-2529-4294-86f6-8ba3879fe1fe"),

                    ProdutcId=11,
                    ProductName="Mobiles",
                    ProductDescription="it is user friendly",
                    ImgUrl="mobile.jpj",
                    Category="Iphone",
                    SubCategory="Iphone14pro"

                },

                 new Product()

                {

                    Id = Guid.Parse("9245fe4a-d402-451c-b9ed-9c1a04247482"),

                    ProdutcId=146,
                    ProductName="Mobiles",
                    ProductDescription="it is user friendly",
                    ImgUrl="mobile.jpj",
                    Category="Realme",
                    SubCategory="Realme10pro"

                },


                 new Product()

                {

                    Id = Guid.Parse("391a17f9-a053-46e5-b0c8-71138939f197"),

                    ProdutcId=130,
                    ProductName="Tv",
                    ProductDescription="it is user friendly",
                    ImgUrl="TV.jpj",
                    Category="Sony",
                    SubCategory="SonyBravia"

                },
                 new Product()

                {

                    Id = Guid.Parse("2d3264b3-1ba4-4f6b-b020-7aa1df3ee3b9"),

                    ProdutcId=148,
                    ProductName="Tv",
                    ProductDescription="it is user friendly",
                    ImgUrl="TV.jpj",
                    Category="Samsung",
                    SubCategory="Samsung9pro"

                },
                  new Product()

                {

                    Id = Guid.Parse("117d947f-31e4-4a96-b2c2-1e2df09ef429"),

                    ProdutcId=149,
                    ProductName="Tv",
                    ProductDescription="it is user friendly",
                    ImgUrl="TV.jpj",
                    Category="OnePlus",
                    SubCategory="OnePlus9pro"

                },
                  new Product()

                {

                    Id = Guid.Parse("4bdf41b9-db10-4923-bdb2-c68a3d4c91d2"),

                    ProdutcId=145,
                    ProductName="Tv",
                    ProductDescription="it is user friendly",
                    ImgUrl="TV.jpj",
                    Category="OnePlus",
                    SubCategory="OnePlus9pro"

                },
                   new Product()

                {

                    Id = Guid.Parse("fc794bfc-4fea-48a3-be89-17c71265a9a8"),

                    ProdutcId=150,
                    ProductName="Tv",
                    ProductDescription="it is user friendly",
                    ImgUrl="TV.jpj",
                    Category="Realme",
                    SubCategory="Realme10pro"

                },






            };

            // Seed difficulties to the database

            modelBuilder.Entity<Product>().HasData(difficulties);



        }
    }
}
