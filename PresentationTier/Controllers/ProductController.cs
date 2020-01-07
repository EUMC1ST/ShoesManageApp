using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessTier;
using EntityTier;
using PresentationTier.Models;

namespace PresentationTier.Controllers
{
    public class ProductController : Controller
    {
        Product productBusiness = new Product();
        List<ProductEntity> product = new List<ProductEntity>();
        ProductsModel productsModel = new ProductsModel(); 

        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            return View(this.GetProducts(1));
        }
        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetProducts(currentPageIndex));
        }

        private ProductsModel GetProducts(int currentPage)
        {
            int registrosPorPagina = 3;
            productsModel.Products = productBusiness.GetProductsPagination(currentPage,registrosPorPagina);
            productsModel.TotalProducts = productBusiness.GetTotalProducts();
            double pageCount = productsModel.TotalProducts / 3;
            productsModel.PageCount = (int)Math.Ceiling(pageCount);
            productsModel.CurrentPageIndex = currentPage;
            return productsModel;
        }

        public ActionResult GetProductsPagination(int pagina)
        {
            int registrosPorPagina = 3; 
            var products = productBusiness.GetProductsPagination(pagina,registrosPorPagina);
            return View("product",products);
        }


        public ActionResult GetProducts()
        {
            var products = productBusiness.GetProducts();
            return View("product",products);
        }

        public ActionResult GetProductById(int? id, string name)
        {
            if (id == null && name == null)
            {
                product = productBusiness.GetProducts();
            }
            else
            {
                if (id != null)
                {
                    product = productBusiness.GetProduct(id, String.Empty);
                }
                else
                {
                    product = productBusiness.GetProduct(null,name);
                }
                
            }
            return View("Product",product);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        public ActionResult Read()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}