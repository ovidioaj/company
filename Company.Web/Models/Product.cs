using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Web.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ProductId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        
        [MaxLength(200)]
        public string Brand { get; set; }
        
        [Required]
        public double price { get; set; }
        
        [Required]
        public byte[] Image { get; set; }
        
        public virtual Stock StockOfOrigin { get; set; }
    }
}