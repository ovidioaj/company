using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Web.Models
{
    [Table("Estoque")]
    public class Stock
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int StockId { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        
        public virtual ICollection<Product> Products { get; set;}
        
        public Stock()
        {
            Products = new Collection<Product>();
        }
    }
}