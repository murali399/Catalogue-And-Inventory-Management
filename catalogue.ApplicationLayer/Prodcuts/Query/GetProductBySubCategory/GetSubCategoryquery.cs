using catalogue.ApplicationLayer.Prodcuts.Query.GetProduct;
using Catalogue.DomainLayer.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProductBySubCategory
{
    public class GetSubCategoryquery:IRequest<List<Product>>
    {
        public string sub { get; set; }
    }
}
