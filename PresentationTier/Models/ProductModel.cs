using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityTier;

namespace PresentationTier.Models
{
    public class ProductModel
    {
        ProductEntity Product { get; set; }
        List<CatColor> Colors { get; set;}
        List<CatTypeProduct> ProductTypes { get; set;}
        List<CatBrand> Brands { get; set;}
        List<CatProvider> providers { get; set;}
        List<CatCatalog> catalogs { get; set; }
    }
}