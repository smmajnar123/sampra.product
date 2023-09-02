using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sampra.Models
{
    public class ProductsData
    {
        List<string> url = new List<string>
        {
                "~/Image/p10.png",
                "~/Image/p1.png",
                "~/Image/p2.png",
                "~/Image/p3.png",
                "~/Image/p4.png",
                "~/Image/p5.png",
                "~/Image/p6.png",
                "~/Image/p7.png",
                "~/Image/p8.png",
                "~/Image/p9.png",
                "~/Image/p10.png",
                "~/Image/p11.png",
         };
        List<string> title = new List<string>
        {
                "Chicken Tikka Kathi Roll",
                "Paneer Kathi Roll",
                "Egg Bhurji Kathi Roll",
                "Mixed Vegetable Kathi Roll",
                "Mutton Seekh Kathi Roll",
                "Aloo Tikki Kathi Roll",
                "Chapli Kebab Kathi Roll",
                "Shrimp Tandoori Kathi Roll",
                "Keema Pav Kathi Roll",
                "Spinach and Cheese Kathi Roll",
                "Spinach and",
                "Seekh Kathi Roll"
         };

        public ProductsData()
        {
            ProductList = new List<ProductImage>();
            if (title.Count==url.Count)
            {
                for (int i = 0; i < title.Count; i++)
                {
                    ProductImage imageModel = new ProductImage();
                    imageModel.ImageUrls = url[i];
                    imageModel.ImageTitle = title[i];
                    ProductList.Add(imageModel);
                }
            }
        }

        public List<ProductImage> ProductList { get; set; }

    }
}