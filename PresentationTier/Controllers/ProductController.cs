using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessTier;
using EntityTier;

namespace PresentationTier.Controllers
{
    public class ProductController : Controller
    {
        Product productBusiness = new Product();
        List<ProductEntity> product = new List<ProductEntity>();
        // GET: Product

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

        public ActionResult GetProducts()
        {
            var products = productBusiness.GetProducts();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
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