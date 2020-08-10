using System;
using System.Collections.Generic;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class PriceListDetail : BasicEntity
    {
        public Guid Id { get; set; }
        public Guid PriceListId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string  Note { get; set; }
    }
}
