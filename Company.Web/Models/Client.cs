using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Web.Models
{
    [Table("Clients")]
    public class Client
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Required]
        public bool FirstVisit { get; set; }

        public DateTime CreateAt { get; set; }
    }
}