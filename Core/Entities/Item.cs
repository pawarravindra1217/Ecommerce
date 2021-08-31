using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public DateTime? CreatedDate { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
