using System;
using System.Collections.Generic;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class BasicEntity
    {
        public bool IsNotUse { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
