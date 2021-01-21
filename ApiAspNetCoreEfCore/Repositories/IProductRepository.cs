using System.Collections.Generic;
using ApiAspNetCoreEfCore.Models;
using ApiAspNetCoreEfCore.ViewModels.ProductViewModels;

namespace ApiAspNetCoreEfCore.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ListProductViewModel> Get();
        Product Get(int id);
        void Save(Product product);
        void Update(Product product);
    }
}