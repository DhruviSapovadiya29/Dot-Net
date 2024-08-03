namespace CoffeeShop.Models
{
    public class BillsModel
    {
        public int BillID { get; set; }
        public string BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public int OrderID { get; set; }
        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public double NetAmount { get; set; }
        public int UserID { get; set; }
    }
}
