using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminka.DataAccess.Entities
{
    [Table("Products")]
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(60), Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public bool InStock { get; set; }
    }
}
