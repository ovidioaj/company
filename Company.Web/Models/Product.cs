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
        [Display(Name = "C�d. Produto")]
        public int ProductId { get; set; }
        
        [Required]
        [MaxLength(200)]
        [Display(Name = "Descri��o")]
        public string Description { get; set; }
        
        [MaxLength(200)]
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        
        [Required]
        [Display(Name = "Pre�o de Venda")]
        public double SellingPrice { get; set; }

        [Required]
        [Display(Name = "C�d. Produto")]
        public double CostPrice { get; set; }

        [Required]
        [Display(Name = "C�d. Produto")]
        public double BuyingPrice { get; set; }
    }
}