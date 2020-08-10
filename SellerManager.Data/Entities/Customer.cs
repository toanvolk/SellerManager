using System;
using System.Collections.Generic;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class Customer : BasicEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
