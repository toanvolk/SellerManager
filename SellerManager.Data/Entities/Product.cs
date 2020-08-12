using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SellerManager.Data.Entities
{
    [Table("Product")]
    public class Product : BasicEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }
        
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string UnitId { get; set; }
        public string Description { get; set; }
    }
}
