using blazorWebApp.App.Models;

namespace blazorWebApp.App.Service
{
    public interface IProductService
    {
        List<Product> Get();
        Product Get(Guid ID);
        List<Product> Add(Product product);
        List<Product> Toggle(Guid ID);
        List<Product> Delete(Guid ID);
    }
}