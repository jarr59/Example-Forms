using ExampleForm.FakestoreApi.Commands.Products;
using Refit;

namespace ExampleForm.FakestoreApi.Sdks
{
    public interface IFakestoreProductSdk
    {
        /// <summary>
        /// Url base de los endpoints de productos
        /// </summary>
        const string URL = "/products";

        /// <summary>
        /// Crea un producto
        /// </summary>
        /// <returns></returns>
        [Post(URL)]
        Task<ProductOutput> CreateProduct(CreateProduct createProduct);
    }
}
