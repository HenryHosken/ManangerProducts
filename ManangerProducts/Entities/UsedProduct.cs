using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManangerProducts.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() 
        {
        }

        public UsedProduct(DateTime manufactureDate, string name, double price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return NameProduct
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
