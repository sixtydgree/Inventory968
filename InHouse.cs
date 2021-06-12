using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class InHouse : Part
    {
        public int MachineID { get; set; }
        private int _PartID { get; set; }
        private string _Name { get; set; }
        private decimal _Price { get; set; }
        private int _InStock { get; set; }
        private int _Min { get; set; }
        private int _Max { get; set; }

        public InHouse(int iD, int partID, string name, decimal price, int inStock, int min, int max)
        {
            MachineID = iD;
            _PartID = partID;
            _Name = name;
            _Price = price;
            _InStock = inStock;
            _Min = min;
            _Max = max;

        }

        

        // Overriding Part propperties.
        public override int PartID
        {
            get
            {
                return _PartID;
            }
            set { PartID = _PartID; }
        }

        public override string Name
        {
            get { return _Name; }
            set { Name = _Name; }
        }

        public override decimal Price
        {
            get { return _Price; }
            set { Price = _Price; }
        }

        public override int InStock
        {
            get { return _InStock; }
            set { InStock = _InStock; }
        }

        public override int Min
        {
            get { return _Min; }
            set { Min = _Min; }
        }

        public override int Max
        {
            get { return _Max; }
            set { Max = _Max; }
        }


    }
    
    
}
