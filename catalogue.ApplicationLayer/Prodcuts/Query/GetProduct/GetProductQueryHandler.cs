using AutoMapper;
using Catalogue.DomainLayer.IReposistory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProduct
{
   
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<Productvm>>

    {
        private readonly IProductRepository productReposistory;
        private readonly IMapper mapper;

        public GetProductQueryHandler(IProductRepository productReposistory,IMapper mapper)
        {
            this.productReposistory = productReposistory;
            this.mapper = mapper;
        }
        public  async Task<List<Productvm>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await productReposistory.GetAllProductAsync();

            var productlist = mapper.Map<List<Productvm>>(products);

            return productlist;

        }
    }
}
