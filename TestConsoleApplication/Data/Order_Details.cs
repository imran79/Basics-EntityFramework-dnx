namespace TestConsoleApplication.Data
{
	  public partial class Order_Detail
    {
     //   public int Order_ID { get; set; }
        public int Product_ID { get; set; }
        public decimal Unit_Price { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    
        public virtual Product Product { get; set; }
       // public virtual Order Order { get; set; }
    }
}