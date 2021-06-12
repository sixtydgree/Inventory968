using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Product 
    {

        public BindingList<Part> AssociatedParts;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, decimal price, int inStock, int min, int max, BindingList<Part> parts)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = parts;
        }

        

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
            return;
        }

        public bool removeAssociatedPart(int e)
        {
            var partFinder =
                from p in AssociatedParts
                where e == p.PartID
                select p;

            AssociatedParts.Remove(partFinder.FirstOrDefault());
            return true;
        }

        public Part lookupAssociatedPart(int e)
        {
            var partFinder =
                 from p in AssociatedParts
                 where e == p.PartID
                 select p;

            return partFinder.FirstOrDefault();
        }
    }
}
