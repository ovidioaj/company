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
        [Display(Name = "Cód. Produto")]
        public int ProductId { get; set; }
        
        [Required]
        [MaxLength(200)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        
        [MaxLength(200)]
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        
        [Required]
        [Display(Name = "Preço de Venda")]
        public double SellingPrice { get; set; }

        [Required]
        [Display(Name = "Cód. Produto")]
        public double CostPrice { get; set; }

        [Required]
        [Display(Name = "Cód. Produto")]
        public double BuyingPrice { get; set; }
    }
}