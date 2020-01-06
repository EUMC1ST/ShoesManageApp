using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using EntityTier;
namespace BusinessTier
{

    public class Product
    {
        private ProductData productData = new ProductData();

        public List<ProductEntity> AddProduct()
        {

            return new List<ProductEntity>();
        }

        public List<ProductEntity> GetProductsPagination(int pagina)
        {
            var products = productData.GetProductsPagination(pagina);
            return products;
        }

        public List<ProductEntity> GetProducts()
        {
            var products = productData.GetProducts();
            return products;
        }
        public List<ProductEntity> GetProduct(int? id, string name)
        {
            var product = productData.GetProductByIdOrName(id, name);
            return product;
        }

        public Int32 EditarProducto(ProductEntity product)
        {
            var wasEdited = productData.EditProduct(product);
            return wasEdited;
        }

        public List<CatColors> GetProductColors()
        {
            return productData.GetProductColors();
        }

        public int DeleteProduct(int id)
        {
            var wasDeleted = productData.DeleteProduct(id);
            return wasDeleted;
        }
    }
}
