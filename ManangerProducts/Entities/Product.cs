﻿using System.Globalization;

namespace ManangerProducts.Entities
{
    internal class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }

        public Product() 
        {
        }

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return NameProduct
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
