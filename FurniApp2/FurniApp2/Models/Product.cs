namespace FurniApp2.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string Url { get; set; }
    }
}
