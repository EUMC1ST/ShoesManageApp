using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using CommonTier;
namespace DataTier
{
    public class ProductData
    {
        private DataProductsEntities  _context = new DataProductsEntities ();
        private List<ProductEntity> products = new List<ProductEntity>();

        public List<ProductEntity> AddProduct()
        {

            return new List<ProductEntity>();
        }
        public int GetTotalProducts()
        {
            return _context.Products.Count();
        }

        public List<ProductEntity> GetProductsPagination(int pagina,int registrosPorPagina)
        {
            if(pagina != 1)
               return Assist.Convert<List<eumc1_function_paginador_Result>,List<ProductEntity>>(_context.eumc1_function_paginador(pagina,registrosPorPagina).ToList());
            products = Assist.Convert<List<eumc1_function_paginador_Result>,List<ProductEntity>>(_context.eumc1_function_paginador(pagina,registrosPorPagina).ToList());
            return products;
        }
        public List<ProductEntity> GetProducts()
        {
            var products = _context.eumc1_getProducts().ToList();
            return Assist.Convert<List<eumc1_getProducts_Result>, List<ProductEntity>>(products); 
        }
        public List<ProductEntity> GetProductByIdOrName(int? id, string name)
        {

            var productObject = _context.eumc1_getProductByIdOrName(id, name).ToList();
            return Assist.Convert<List<eumc1_getProductByIdOrName_Result>, List<ProductEntity>>(productObject);
        }

        public Int32 EditProduct(ProductEntity product)
        {
            var isProductEdited = _context.eumc1_editProduct(
                product.Id,
                product.IdType,
                product.IdColor,
                product.IdBrand,
                product.IdProvider,
                product.IdCatalog,
                product.Nombre,
                product.Title,
                product.Description,
                product.Observations,
                product.PriceDistributor,
                product.PriceClient,
                product.PriceMember,
                product.IsEnabled,
                product.Keywords,
                product.DateUpdate
                );
            return isProductEdited;
        }

        public int DeleteProduct(int productId)
        {
            var isProductDeleted = _context.eumc1_deleteProductById(productId);
            return isProductDeleted;
        }


        public List<EntityTier.CatColor> GetProductColors()
        {
            var productColor = _context.eumc1_getProductColors().ToList();
            return Assist.Convert<List<eumc1_getProductColors_Result>, List<EntityTier.CatColor>>(productColor);
        }

        public List<EntityTier.CatTypeProduct> GetProductTypes()
        {
            var productsType = _context.eumc1_getProductType().ToList();

            return Assist.Convert<List<eumc1_getProductType_Result>, List<EntityTier.CatTypeProduct>>(productsType);
        }

        public List<EntityTier.CatCatalog> GetProductCatalogs()
        {
            var productsCatalogs = _context.eumc1_getCatalogs().ToList();

            return Assist.Convert<List<eumc1_getCatalogs_Result>, List<EntityTier.CatCatalog>>(productsCatalogs);
        }

        public List<EntityTier.CatBrand> GetProductBrands()
        {
            var productsBrands = _context.eumc1_getBrands().ToList();

            return Assist.Convert<List<eumc1_getBrands_Result>, List<EntityTier.CatBrand>>(productsBrands);
        }

        public List<EntityTier.CatProvider> GetProductProviders()
        {
            var productsProviders = _context.eumc1_getProviders().ToList();

            return Assist.Convert<List<eumc1_getProviders_Result>, List<EntityTier.CatProvider>>(productsProviders);
        }

        public List<EntityTier.CatBrand> GetProduct()
        {
            var productsBrands = _context.eumc1_getBrands().ToList();

            return Assist.Convert<List<eumc1_getBrands_Result>, List<EntityTier.CatBrand>>(productsBrands);
        }

        public int CreateProduct(Product product)
        {

            return 1;
        }

    }
}
