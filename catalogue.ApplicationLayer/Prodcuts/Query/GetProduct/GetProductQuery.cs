using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProduct
{
    public class GetProductQuery: IRequest<List<Productvm>>

    {
    }
}
