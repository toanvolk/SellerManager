using System;
using System.Collections.Generic;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class PriceList : BasicEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeApply { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
    }
}
