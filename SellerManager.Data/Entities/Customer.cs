using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SellerManager.Data.Entities
{
    [Table("Customer")]
    public class Customer : BasicEntity
    {
        [Key]
        [StringLength(50)]
        public string CustomerId { get; set; }
        
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
