﻿namespace EC_Medicines_Store.Models
{
    public class OrderItems
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int MedicineID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Qunatity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
