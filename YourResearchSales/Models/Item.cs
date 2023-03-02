namespace YourResearchSales.Models
{
    public class Item
    {
        public int ID { get; set; }

        public int SalesOrderID { get; set; }

        public string Article { get; set; }

        public float Amount { get; set; }
    }
}
