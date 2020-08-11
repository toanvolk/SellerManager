using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SellerManager.Data.Entities
{
    public class BasicEntity
    {
        public bool IsNotUse { get; set; }
        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyBy { get; set; }
    }
}
