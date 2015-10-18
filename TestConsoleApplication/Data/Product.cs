using System.ComponentModel.DataAnnotations.Schema;
namespace TestConsoleApplication.Data
{


    public partial class Product
    {
        public Product()
        {
            //this.Order_Details = new HashSet<Order_Detail>();
        }
        [Column("ProductID")]
        public int Id { get; set; }
        [Column("SupplierID")]
        public int? SupplierId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [Column("ProductName")]
        public string Name { get; set; }

        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        // public virtual ICollection<Order_Detail> Order_Details { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
    }
}