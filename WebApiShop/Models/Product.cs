using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(), MinLength(5)]
        public String Name { get; set; }
        //public String Desription { get; set; }
        [Required]
        public decimal Price { get; set; }
        //public virtual Category Category { get; set; }
        //public ICollection<Review> Reviews {get;set;}
        //public String Desription1 { get; set; }
    }
}
