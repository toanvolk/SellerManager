using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SellerManager.Data.Entities
{
    [Table("PriceListDetail")]
    public class PriceListDetail : BasicEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public Guid PriceListId { get; set; }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string  Note { get; set; }
    }
}
