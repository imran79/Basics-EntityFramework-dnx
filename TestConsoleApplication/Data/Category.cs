using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace  TestConsoleApplication.Data

{
	 public partial class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
	
}