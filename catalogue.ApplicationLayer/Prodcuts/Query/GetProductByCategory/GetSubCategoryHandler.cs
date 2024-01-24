using AutoMapper;
using catalogue.ApplicationLayer.Prodcuts.Query.GetProduct;
using Catalogue.DomainLayer.Entity;
using Catalogue.DomainLayer.IReposistory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProductByCategory
{
    public class GetSubCategoryHandler : IRequestHandler<GetCategoryQuery, List<Product>>
    {
        private readonly IProductRepository productReposistory;
        private readonly IMapper mapper;

        public GetSubCategoryHandler(IProductRepository productReposistory, IMapper mapper)
        {
            this.productReposistory = productReposistory;
            this.mapper = mapper;
        }



        public async Task<List<Product>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var products = await productReposistory.GetProductByCategoryAsync(request.cat);
            return products.ToList();

        }
    }
}

