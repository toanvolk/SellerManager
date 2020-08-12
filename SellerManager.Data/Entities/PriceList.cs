using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SellerManager.Data.Entities
{
    [Table("PriceList")]
    public class PriceList : BasicEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        public DateTime TimeApply { get; set; }
        public string Description { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }
    }
}
