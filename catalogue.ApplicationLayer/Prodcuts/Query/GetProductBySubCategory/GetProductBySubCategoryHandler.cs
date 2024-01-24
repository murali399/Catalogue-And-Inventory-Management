using AutoMapper;
using Catalogue.DomainLayer.Entity;
using Catalogue.DomainLayer.IReposistory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogue.ApplicationLayer.Prodcuts.Query.GetProductBySubCategory
{
    public class GetProductBySubCategoryHandler:IRequestHandler<GetSubCategoryquery, List<Product>>
    {
        private readonly IProductRepository productReposistory;
    private readonly IMapper mapper;

    public GetProductBySubCategoryHandler(IProductRepository productReposistory, IMapper mapper)
    {
        this.productReposistory = productReposistory;
        this.mapper = mapper;
    }
    public  async Task<List<Product>> Handle(GetSubCategoryquery request, CancellationToken cancellationToken)
        {
            var products = await productReposistory.GetProductBySubCategoryAsync(request.sub);
            return products.ToList();

        }
    }
}
