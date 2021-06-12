using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public abstract class Part
    {
        public abstract int PartID { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int InStock { get; set; }
        public abstract int Min { get; set; }
        public abstract int Max { get; set; }

        

        

       
    }
}
