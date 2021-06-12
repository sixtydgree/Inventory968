using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryHome : Form
    {
        public static int productID, partID;
        private string prodSearch, partSearch;

        public static decimal partPrice, prodPrice;
        


        public InventoryHome()
        {
            InitializeComponent();
            //Populate items in both lists to give evaluator something to start with.
            //Parts
            BindingList<Part> parts = new BindingList<Part>();
            Outsourced outsourced = new Outsourced("Mitch Tooling", GlobalInv.inventory.AllParts.Count, "PVC Plastic", 1.95M, 1200, 10, 100);
            GlobalInv.inventory.AddPart(outsourced);
            Outsourced outsourced2 = new Outsourced("Mitch Tooling", GlobalInv.inventory.AllParts.Count, "PVC Glue", 2.30M, 1025, 5, 200);
            GlobalInv.inventory.AddPart(outsourced2);
            InHouse inHouse = new InHouse(5166743, GlobalInv.inventory.AllParts.Count, "LED Board", 0.15M, 500, 1, 20);
            GlobalInv.inventory.AddPart(inHouse);
            InHouse inHouse1 = new InHouse(4261378, GlobalInv.inventory.AllParts.Count, "Monitor Control Circuit", 2.50M, 1000, 1, 250);
            GlobalInv.inventory.AddPart(inHouse1);
            //Products
            parts.Add(GlobalInv.inventory.AllParts[2]);
            parts.Add(GlobalInv.inventory.AllParts[3]);
            Product product1 = new Product(GlobalInv.inventory.Products.Count, "80\" LCD Television", 1500.00M, 124, 1, 5, parts);
            GlobalInv.inventory.AddProduct(product1);
            parts.Clear();
            parts.Add(GlobalInv.inventory.AllParts[0]);
            parts.Add(GlobalInv.inventory.AllParts[1]);
            Product product2 = new Product(GlobalInv.inventory.Products.Count, "Model Airplane (f_16)", 25.00M, 300, 1, 10, parts);
            GlobalInv.inventory.AddProduct(product2);



            //provide data sources for both inventory lists.
            PartGrid.DataSource = GlobalInv.inventory.AllParts;
            ProductGrid.DataSource = GlobalInv.inventory.Products;
        }

        //Grid selections___________________________________________________________________________________________________________________


        
        private void PartGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (PartGrid.SelectedRows.Count > 0)
            {
                partID = int.Parse(PartGrid.SelectedCells[0].Value.ToString());
            }
        }

        private void PartGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(PartGrid.SelectedRows.Count > 0)
            {
                var partFinder = from p in GlobalInv.inventory.AllParts
                                 where p.PartID == int.Parse(PartGrid.SelectedCells[0].Value.ToString())
                                 select p;
                if(partFinder.First() is InHouse)
                {
                    InHouse a = (InHouse)partFinder.FirstOrDefault();
                    MessageBox.Show($"Machine ID: {a.MachineID}");
                    return;
                }
                else
                {
                    Outsourced b = (Outsourced)partFinder.FirstOrDefault();
                    MessageBox.Show($"Company Name: {b.CompanyName}");
                    return;
                }
            }
        }

        private void ProductGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(ProductGrid.SelectedRows.Count > 0)
            {
                productID = int.Parse(ProductGrid.SelectedCells[0].Value.ToString());
            }
        }

        private void ProdSearchTXT_TextChanged(object sender, EventArgs e)
        {
            prodSearch = ProdSearchTXT.Text;
        }

        private void PartSearchTXT_TextChanged(object sender, EventArgs e)
        {
            partSearch = PartSearchTXT.Text;
        }


        //__________________________________________________________________________________________________________________________________


        //Button controls_________________________________________________________________________________________
        private void ProdAdd_Click(object sender, EventArgs e)
        {
            var addProd = new AddProduct();
            addProd.Location = this.Location;
            addProd.StartPosition = FormStartPosition.Manual;
            addProd.FormClosing += delegate { this.Show(); };
            addProd.Show();
            this.Hide();
        }

        private void PartAdd_Click(object sender, EventArgs e)
        {
            var addPart = new AddPart();
            addPart.Location = this.Location;
            addPart.StartPosition = FormStartPosition.Manual;
            addPart.FormClosing += delegate { this.Show(); };
            addPart.Show();
            this.Hide();
        }

        private void PartMod_Click(object sender, EventArgs e)
        {
            if(PartGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part.", "No Part Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var modPart = new PartMod();
                modPart.Location = this.Location;
                modPart.StartPosition = FormStartPosition.Manual;
                modPart.FormClosing += delegate { this.Show(); };
                modPart.Show();
                this.Hide();
            }
            
        }

        private void ProdMod_Click(object sender, EventArgs e)
        {
            if (ProductGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a product.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var modProd = new ModProd();
                modProd.Location = this.Location;
                modProd.StartPosition = FormStartPosition.Manual;
                modProd.FormClosing += delegate { this.Show(); };
                modProd.Show();
                this.Hide();
            }
            
        }

        private void PartDelete_Click(object sender, EventArgs e)
        {
            if(PartGrid.SelectedRows.Count > 0)
            {
                var selectedOption = MessageBox.Show("Are you sure you want to delete this part?", "DELETE?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (selectedOption == DialogResult.OK)
                {
                    GlobalInv.inventory.DeletePart(partID);
                    if (GlobalInv.inventory.DeletePart(partID) == false)
                    {
                        MessageBox.Show("Part could not be found.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else { return; }
            }
            else { MessageBox.Show("Plese select a part.", "No Part Selected", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            
            

        }

        private void ProdDelete_Click(object sender, EventArgs e)
        {
            if(ProductGrid.SelectedRows.Count > 0)
            {
                var selectedOption = MessageBox.Show("Are you sure you would like to delete this product?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (selectedOption == DialogResult.OK)
                {
                    GlobalInv.inventory.RemoveProduct(productID);
                    if (GlobalInv.inventory.RemoveProduct(productID) == false)
                    {
                        MessageBox.Show("Product not found.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Please select a product.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void PartGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartGrid.ClearSelection();
        }

        private void ProductGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductGrid.ClearSelection();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProdSearchBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalInv.inventory.Products.Count; i++)
            {
                ProductGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            var prodFinder = from p in GlobalInv.inventory.Products
                             where p.Name.ToLower().Contains(prodSearch.ToLower())
                             select p;
            if (prodFinder.Any())
            {

                int index = GlobalInv.inventory.Products.IndexOf(prodFinder.FirstOrDefault());
                ProductGrid.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("No product by that name.", "No Product found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void PartSearchBTN_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < GlobalInv.inventory.AllParts.Count; i++)
            {
                PartGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            var partFinder = from p in GlobalInv.inventory.AllParts
                             where p.Name.ToLower().Contains(partSearch.ToLower())
                             select p;
            if (partFinder.Any())
            {

                int index = GlobalInv.inventory.AllParts.IndexOf(partFinder.FirstOrDefault());
                PartGrid.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("There are no parts by that name.", "No part found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        //__________________________________________________________________________________________________________________________________





    }
}
