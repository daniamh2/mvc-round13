using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace KaShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Column ("varchar (50)")]
        [MaxLength (50)]
        [MinLength (3)]
        [Required]
        public string Name { get; set; }
        [ValidateNever]

        public List<Product> Products { get; set; }
    }
}
