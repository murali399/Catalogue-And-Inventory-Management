using catalogue.ApplicationLayer.Prodcuts.Query.GetProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProductById
{
    public class GetProdctByIdQuery:IRequest<Productvm>
    {
        public int ProId { get; set; }
    }
}
