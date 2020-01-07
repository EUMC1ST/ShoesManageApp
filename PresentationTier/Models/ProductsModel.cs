using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityTier;

namespace PresentationTier.Models
{
    public class ProductsModel
    {
        public List<ProductEntity> Products { get; set; }
        public int PageCount { get; set; }
        public int CurrentPageIndex { get; set; }
        public int TotalProducts { get; set; }
    }
}