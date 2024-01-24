using AutoMapper;
using catalogue.ApplicationLayer.Prodcuts.Query.GetProduct;
using Catalogue.DomainLayer.IReposistory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProductById
{
    public class GetProductbyIdQueryHandler : IRequestHandler<GetProdctByIdQuery, Productvm>
    {
        private readonly IProductRepository productReposistory;
        private readonly IMapper mapper;

        public GetProductbyIdQueryHandler(IProductRepository productReposistory,IMapper mapper)
        {
            this.productReposistory = productReposistory;
            this.mapper = mapper;
        }
        public  async Task<Productvm> Handle(GetProdctByIdQuery request, CancellationToken cancellationToken)
        {
            
            var blog = await productReposistory.GetProdcutByIdAsync(request.ProId);
            // Mapp domain to dto 
            var productlist = mapper.Map<Productvm>(blog);
            return productlist;

        }
    }
}
