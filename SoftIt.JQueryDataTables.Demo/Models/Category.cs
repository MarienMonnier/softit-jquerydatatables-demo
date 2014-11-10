namespace SoftIt.JQueryDataTables.Demo.Models
{
    public class Category
    {
        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}