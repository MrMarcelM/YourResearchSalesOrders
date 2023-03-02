namespace YourResearchSales.Models
{
    public class SalesOrder
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
