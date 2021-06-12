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
    public partial class AddProduct : Form
    {
        private int newProdID = GlobalInv.inventory.Products.Count();
        private int productID, partID, selectedAssocPart;
        private string searchWrd;
        private bool isInvInt, isMaxInt, isMinInt,  isPriceDec;
        private bool isMaxHigher = true;
        private Part selectedPart;
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private BindingSource bindingSource = new BindingSource();
        private Product product;


        public AddProduct()
        {
            InitializeComponent();
            productID = GlobalInv.inventory.ProductID();
            var productIDSearch = from p in GlobalInv.inventory.Products
                                  where productID == p.ProductID
                                  select p;
            if (productIDSearch.Any())
            {
                productID++;
            }
            product = new Product(productID, "", 0m, 0, 0, 0, associatedParts);
            bindingSource.DataSource = GlobalInv.inventory.AllParts;
            Can_Parts.DataSource = bindingSource;
            AssociatingParts.DataSource = product.AssociatedParts;
        }

        //Input for variables____________________________________________________
        private void ProdName_TextChanged(object sender, EventArgs e)
        {
            ProdName.BackColor = Color.White;
            product.Name = ProdName.Text;
        }

        private void Inventory_TextChanged(object sender, EventArgs e)
        {
            Inventory.BackColor = Color.White;
            if(int.TryParse(Inventory.Text, out int result))
            {
                isInvInt = true;
                product.InStock = result;
            }
            else
            {
                isInvInt = false;
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            Price.BackColor = Color.White;
            if(decimal.TryParse(Price.Text, out decimal result))
            {
                isPriceDec = true;
                product.Price = result;
            }
            else
            {
                isPriceDec = false;
            }
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
            Max.BackColor = Color.White;
            if (int.TryParse(Max.Text, out int result))
            {
                isMaxInt = true;
                product.Max = result;
            }
            else
            {
                isMaxInt = false;
            }
        }

        private void Can_Parts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Can_Parts.SelectedRows.Count > 0)
            {
                var partFinder = from p in GlobalInv.inventory.AllParts
                                 where int.Parse(Can_Parts.SelectedCells[0].Value.ToString()) == p.PartID
                                 select p;
                if(partFinder.FirstOrDefault() is InHouse)
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

        private void AssociatingParts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(AssociatingParts.SelectedRows.Count > 0)
            {
                var partFinder = from p in associatedParts
                                 where int.Parse(AssociatingParts.SelectedCells[0].Value.ToString()) == p.PartID
                                 select p;
                selectedAssocPart = partFinder.FirstOrDefault().PartID;
            }
        }

        private void Can_Parts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Can_Parts.SelectedRows.Count > 0)
            {
                partID = int.Parse(Can_Parts.SelectedCells[0].Value.ToString());
            }

            selectedPart = GlobalInv.inventory.LookupPart(partID);
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
            Min.BackColor = Color.White;
            if(int.TryParse(Min.Text, out int result))
            {
                isMinInt = true;
                product.Min = result;
            }else
            {
                isMinInt = false;
            }
            if(product.Min > product.Max)
            {
                isMaxHigher = false;
            }
        }

        private void Can_Parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Can_Parts.ClearSelection();
        }

        private void AssociatingParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AssociatingParts.ClearSelection();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            searchWrd = SearchText.Text;
        }
        //_______________________________________________________________________

        //Button behavior________________________________________________________
        private void Add_Click(object sender, EventArgs e)
        {
            if(selectedPart != null)
            {
                product.addAssociatedPart(selectedPart);
            }
            else { MessageBox.Show("No part selected", "Select part", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalInv.inventory.AllParts.Count; i++)
            {
                Can_Parts.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            var searchedParts = from p in GlobalInv.inventory.AllParts
                                where p.Name.ToLower().Contains(searchWrd.ToLower())
                                select p;
            if (searchedParts.Any())
            {

                int index = GlobalInv.inventory.AllParts.IndexOf(searchedParts.FirstOrDefault());
                Can_Parts.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("No part found by that name.", "No Part Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            product.removeAssociatedPart(selectedAssocPart);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(!isInvInt || Inventory == null)
            {
                Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must contain a number.", "Invalid Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (!isMaxInt)
            {
                Max.BackColor = Color.Red;
                MessageBox.Show("Max must contain a number.", "Invalid Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (!isMinInt)
            {
                Min.BackColor = Color.Red;
                MessageBox.Show("Min must contain a number.", "Invalid Min", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (!isPriceDec)
            {
                Price.BackColor = Color.Red;
                MessageBox.Show("Price must contain a number with no more than two decimal places.", "Ivalid Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (!isMaxHigher)
            {
                Max.BackColor = Color.Red;
                MessageBox.Show("Max must be higher than Min.", "Max is too small", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(ProdName.Text == null || product.Name == "")
            {
                ProdName.BackColor = Color.Red;
                MessageBox.Show("The product needs a name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(AssociatingParts.Rows.Count == 0)
            {
                AssociatingParts.BackgroundColor = Color.Red;
                MessageBox.Show("Products must have associated parts.", "No parts associated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                GlobalInv.inventory.AddProduct(product);
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //_______________________________________________________________________
    }
}
