using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.JSON
{
    class ProductMain
    {
        static void Main(string[] args)
        {
            Products p1 = new Products
            {
                Name = "Product 1",
                Price = 99.95,
                ExpiryDate = new DateTime(2000, 12, 29, 0, 0, 0, DateTimeKind.Utc),
            };
            Products p2 = new Products
            {
                Name = "Product 2",
                Price = 12.50,
                ExpiryDate = new DateTime(2009, 7, 31, 0, 0, 0, DateTimeKind.Utc),
            };

            List<Products> products = new List<Products>();
            products.Add(p1);
            products.Add(p2);

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            //[
            //  {
            //    "Name": "Product 1",
            //    "ExpiryDate": "2000-12-29T00:00:00Z",
            //    "Price": 99.95,
            //    "Sizes": null
            //  },
            //  {
            //    "Name": "Product 2",
            //    "ExpiryDate": "2009-07-31T00:00:00Z",
            //    "Price": 12.50,
            //    "Sizes": null
            //  }
            //]
        }
    }
}
