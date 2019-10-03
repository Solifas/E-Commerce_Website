using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Website.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public string ProductDescription { get; set; }
        public string Website { get; set; }
        public string SupplierName { get; set; }
        [Column(TypeName = "image")]
        public byte[] ProductImage { get; set; }

        public Supplier Suppliers { get; set; }
        public Category Categories { get; set; }
    }
}
