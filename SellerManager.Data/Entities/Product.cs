using System;
using System.Collections.Generic;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class Product : BasicEntity
    {
        public int Id { get; set; } 
        public string Code { get; set; }
        public string Name { get; set; }
        public string UnitId { get; set; }
        public string Description { get; set; }
    }
}
