using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        
        Task<ProductBrand> GetProductBrandByIdAsync(int id);
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        
        Task<ProductType> GetProductTypeByIdAsync(int id);
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}