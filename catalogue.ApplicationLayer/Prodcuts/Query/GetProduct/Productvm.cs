using catalogue.ApplicationLayer.Common.Mapper;
using Catalogue.DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProduct
{
    public class Productvm:IMapFrom<Product>
    {
        public Guid Id { get; set; }
        public int ProdutcId { get; set; }

        public string ProductName { get; set; }


        public string ProductDescription { get; set; }


        public string ImgUrl { get; set; }


        public string Category { get; set; }

        public string SubCategory { get; set; }

    }
}
