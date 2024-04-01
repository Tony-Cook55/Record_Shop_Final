namespace RecordShop.Models
{
    public class CustomerProducts
    {
        public int CustomerModelId { get; set; }
        public CustomerModel Customers { get; set; }

        public int ProductModelId { get; set; }
        public ProductModel Products { get; set; }

    }
}
