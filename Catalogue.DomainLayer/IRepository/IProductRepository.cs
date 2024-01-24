using Catalogue.DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.DomainLayer.IReposistory
{
    public interface IProductRepository
    {
       /// <summary>
       /// It Displays All Products in Catalogue
       /// </summary>
       /// <returns>List Of Products</returns>
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<IEnumerable<Product>> GetProductByCategoryAsync(string category);

        Task<IEnumerable<Product>> GetProductBySubCategoryAsync(string subCategory);


        Task<Product> GetProdcutByIdAsync(int id);

    }
}
