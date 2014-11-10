using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SoftIt.JQueryDataTables.Demo.Models;

namespace SoftIt.JQueryDataTables.Demo.Services
{
    public class ProductService
    {
        private static readonly List<Product> Products;

        static ProductService()
        {
            Products = new List<Product>
                       {
                           new Product(1, "Chai", 18.0000m),
                           new Product(2, "Chang", 19.0000m),
                           new Product(3, "Aniseed Syrup", 10.0000m),
                           new Product(4, "Chef Antos Cajun Seasoning", 22.0000m),
                           new Product(5, "Chef Antos Gumbo Mix", 21.3500m),
                           new Product(6, "Grandmas Boysenberry Spread", 25.0000m),
                           new Product(7, "Uncle Bobs Organic Dried Pears", 30.0000m),
                           new Product(8, "Northwoods Cranberry Sauce", 40.0000m),
                           new Product(9, "Mishi Kobe Niku", 97.0000m),
                           new Product(10, "Ikura", 31.0000m),
                           new Product(11, "Queso Cabrales", 21.0000m),
                           new Product(12, "Queso Manchego La Pastora", 38.0000m),
                           new Product(13, "Konbu", 6.0000m),
                           new Product(14, "Tofu", 23.2500m),
                           new Product(15, "Genen Shouyu", 15.5000m),
                           new Product(16, "Pavlova", 17.4500m),
                           new Product(17, "Alice Mutto", 39.0000m),
                           new Product(18, "Carnarvon Tigers", 62.5000m),
                           new Product(19, "Teatime Chocolate Biscuits", 9.2000m),
                           new Product(20, "Sir Rodneys Marmalade", 81.0000m),
                           new Product(21, "Sir Rodneys Scones", 10.0000m),
                           new Product(22, "Gustafs Knäckebröd", 21.0000m),
                           new Product(23, "Tunnbröd", 9.0000m),
                           new Product(24, "Guaraná Fantástica", 4.5000m),
                           new Product(25, "NuNuCa Nuß-Nougat-Creme", 14.0000m),
                           new Product(26, "Gumbär Gummibärche", 31.2300m),
                           new Product(27, "Schoggi Schokolade", 43.9000m),
                           new Product(28, "Rössle Sauerkraut", 45.6000m),
                           new Product(29, "Thüringer Rostbratwurst", 123.7900m),
                           new Product(30, "Nord-Ost Matjeshering", 25.8900m),
                           new Product(31, "Gorgonzola Telino", 12.5000m),
                           new Product(32, "Mascarpone Fabioli", 32.0000m),
                           new Product(33, "Geitost", 2.5000m),
                           new Product(34, "Sasquatch Ale", 14.0000m),
                           new Product(35, "Steeleye Stout", 18.0000m),
                           new Product(36, "Inlagd Sill", 19.0000m),
                           new Product(37, "Gravad lax", 26.0000m),
                           new Product(38, "Côte de Blaye", 263.5000m),
                           new Product(39, "Chartreuse verte", 18.0000m),
                           new Product(40, "Boston Crab Meat", 18.4000m),
                           new Product(41, "Jacks New England Clam Chowder", 9.6500m),
                           new Product(42, "Singaporean Hokkien Fried Mee", 14.0000m),
                           new Product(43, "Ipoh Coffee", 46.0000m),
                           new Product(44, "Gula Malacca", 19.4500m),
                           new Product(45, "Rogede sild", 9.5000m),
                           new Product(46, "Spegesild", 12.0000m),
                           new Product(47, "Zaanse koeke", 9.5000m),
                           new Product(48, "Chocolade", 12.7500m),
                           new Product(49, "Maxilaku", 20.0000m),
                           new Product(50, "Valkoinen suklaa", 16.2500m),
                           new Product(51, "Manjimup Dried Apples", 53.0000m),
                           new Product(52, "Filo Mix", 7.0000m),
                           new Product(53, "Perth Pasties", 32.8000m),
                           new Product(54, "Tourtière", 7.4500m),
                           new Product(55, "Pâté chinois", 24.0000m),
                           new Product(56, "Gnocchi di nonna Alice", 38.0000m),
                           new Product(57, "Ravioli Angelo", 19.5000m),
                           new Product(58, "Escargots de Bourgogne", 13.2500m),
                           new Product(59, "Raclette Courdavault", 55.0000m),
                           new Product(60, "Camembert Pierrot", 34.0000m),
                           new Product(61, "Sirop dérable", 28.5000m),
                           new Product(62, "Tarte au sucre", 49.3000m),
                           new Product(63, "Vegie-spread", 43.9000m),
                           new Product(64, "Wimmers gute Semmelknödel", 33.2500m),
                           new Product(65, "Louisiana Fiery Hot Pepper Sauce", 21.0500m),
                           new Product(66, "Louisiana Hot Spiced Okra", 17.0000m),
                           new Product(67, "Laughing Lumberjack Lager", 14.0000m),
                           new Product(68, "Scottish Longbreads", 12.5000m),
                           new Product(69, "Gudbrandsdalsost", 36.0000m),
                           new Product(70, "Outback Lager", 15.0000m),
                           new Product(71, "Flotemysost", 21.5000m),
                           new Product(72, "Mozzarella di Giovanni", 34.8000m),
                           new Product(73, "Röd Kaviar", 15.0000m),
                           new Product(74, "Longlife Tofu", 10.0000m),
                           new Product(75, "Rhönbräu Klosterbier", 7.7500m),
                           new Product(76, "Lakkalikööri", 18.0000m),
                           new Product(77, "Original Frankfurter grüne Soße", 13.0000m)
                       };
        }

        public List<Product> GetProducts(string search, string sortOrder, int start, int length, decimal? minPrice, decimal? maxPrice)
        {
            return FilterProducts(search, minPrice, maxPrice).SortBy(sortOrder).Skip(start).Take(length).ToList();
        }

        public int Count(string search, decimal? minPrice, decimal? maxPrice)
        {
            return FilterProducts(search, minPrice, maxPrice).Count();
        }

        private IQueryable<Product> FilterProducts(string search, decimal? minPrice, decimal? maxPrice)
        {
            IQueryable<Product> results = Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
                results = results.Where(p => p.Name.Contains(search));

            if (minPrice.HasValue)
                results = results.Where(p => p.UnitPrice >= minPrice.Value);

            if (maxPrice.HasValue)
                results = results.Where(p => p.UnitPrice <= maxPrice.Value);

            return results;
        }
    }
}