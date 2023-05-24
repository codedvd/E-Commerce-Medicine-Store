namespace EC_Medicines_Store.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Qunatity { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Cart> listCart { get; set; }
    }
}
