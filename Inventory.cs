using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public BindingList<Part> AllParts = new BindingList<Part>();
        public int prodID, partID;



        public int ProductID()
        {
            prodID = Products.Count;
            return prodID++;
        }

        public int PartID()
        {
            partID = AllParts.Count;
            return partID++;
        }
        

        public void AddProduct(Product product)
        {
            Products.Add(product);
            return;
        }

        public bool RemoveProduct(int e)
        {
            
            if (LookupProduct(e)?.AssociatedParts?.Any() == false)
            {
                Products.Remove(LookupProduct(e));
                return true;
            }
            else
            {

                return false;
            }

        }


        public Product LookupProduct(int e)
        {
            var prodFinder =
                from p in Products
                where e == p.ProductID
                select p;

            return prodFinder.FirstOrDefault();
        }

        public void UpdateProduct(int e, Product product)
        {
           
            int index = Products.IndexOf(LookupProduct(e));
            Products.Remove(LookupProduct(e));
            Products.Insert(index, product);
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
            return;
        }

        public bool DeletePart(int e)
        {
            AllParts.Remove(LookupPart(e));
            return true;
        }

        public Part LookupPart(int e)
        {
           
            var partFinder =
                from p in AllParts
                where e == p.PartID
                select p;
           return partFinder.FirstOrDefault();

        }

        public void UpdatePart(int e, Part part)
        {
            int index = AllParts.IndexOf(LookupPart(e));
            DeletePart(e);
            AllParts.Insert(index, part);


            return;
        }

        

    }
}
