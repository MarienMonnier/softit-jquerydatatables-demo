namespace SoftIt.JQueryDataTables.Demo.Models
{
    public class Product
    {
        public Product(int id, string name, decimal unitPrice)
        {
            ID = id;
            Name = name;
            UnitPrice = unitPrice;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}