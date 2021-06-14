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
    public partial class ModProd : Form
    {
        private Product productSelected = GlobalInv.inventory.LookupProduct(InventoryHome.productID);
        private bool isInvInt, isMinInt, isMaxInt, isPriceDec;
        private string searchWRD;
        private int partID, selPartID;
        private BindingSource bindingSource = new BindingSource();


        public ModProd()
        {
            InitializeComponent();

            //initialize componants____________________________________________________________________________
            
            bindingSource.DataSource = GlobalInv.inventory.AllParts;

            ID.Text = InventoryHome.productID.ToString();
            ProdName.Text = productSelected.Name;
            Inventory.Text = productSelected.InStock.ToString();
            Price.Text = productSelected.Price.ToString();
            Min.Text = productSelected.Min.ToString();
            Max.Text = productSelected.Max.ToString();
            Can_Parts.DataSource = bindingSource;
            AssociatedParts.DataSource = productSelected.AssociatedParts;
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
            Min.BackColor = Color.White;
            if(int.TryParse(Min.Text, out int result))
            {
                isMinInt = true;
                productSelected.Min = result;
            }
            else
            {
                isMinInt = false;
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            searchWRD = SearchText.Text;
        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {
            ProdName.BackColor = Color.White;
            productSelected.Name = ProdName.Text;
        }

        private void Can_Parts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Can_Parts.SelectedRows.Count > 0)
            {
                partID = int.Parse(Can_Parts.SelectedCells[0].Value.ToString());
            }
        }

        private void Inventory_TextChanged(object sender, EventArgs e)
        {
            Inventory.BackColor = Color.White;
            if(int.TryParse(Inventory.Text, out int result))
            {
                isInvInt = true;
                productSelected.InStock = result;
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
                productSelected.Price = result;
            }
            else
            {
                isPriceDec = false;
            }
        }


        private void AssociatedParts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(AssociatedParts.SelectedRows.Count > 0)
            {
                selPartID = int.Parse(AssociatedParts.SelectedCells[0].Value.ToString());
            }
        }


        private void Max_TextChanged(object sender, EventArgs e)
        {
            Max.BackColor = Color.White;
            if(int.TryParse(Max.Text, out int result))
            {
                isMaxInt = true;
                productSelected.Max = result;
            }
            else
            {
                isMaxInt = false;
            }
        }

        private void Can_Parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Can_Parts.ClearSelection();
        }

        private void AssociatedParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AssociatedParts.ClearSelection();
        }

        //Buttons_____________________________________________________________________________
        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalInv.inventory.AllParts.Count; i++)
            {
                Can_Parts.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            var partFinder = from p in GlobalInv.inventory.AllParts
                             where p.Name.ToLower().Contains(searchWRD.ToLower())
                             select p;
            if (partFinder.Any())
            {

                int index = GlobalInv.inventory.AllParts.IndexOf(partFinder.FirstOrDefault());
                Can_Parts.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("No part found by that name.", "No Part Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var selectedPart = from p in GlobalInv.inventory.AllParts
                               where partID == p.PartID
                               select p;
            productSelected.addAssociatedPart(selectedPart.FirstOrDefault());
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           productSelected.removeAssociatedPart(selPartID);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!isInvInt || Inventory == null)
            {
                Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must contain a number.", "Invalid Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isMaxInt)
            {
                Max.BackColor = Color.Red;
                MessageBox.Show("Max must contain a number.", "Invalid Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isMinInt)
            {
                Min.BackColor = Color.Red;
                MessageBox.Show("Min must contain a number.", "Invalid Min", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isPriceDec)
            {
                Price.BackColor = Color.Red;
                MessageBox.Show("Price must contain a number with no more than two decimal places.", "Ivalid Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(Min.Text) > int.Parse(Max.Text))
            {
                Max.BackColor = Color.Red;
                MessageBox.Show("Max must be higher than Min.", "Max is too small", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ProdName.Text == null || productSelected.Name == "")
            {
                ProdName.BackColor = Color.Red;
                MessageBox.Show("The product needs a name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (int.Parse(Inventory.Text) > int.Parse(Max.Text))
            {
                Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must not be higher than Max value.", "Inventory exceeded maximum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(int.Parse(Inventory.Text) < int.Parse(Min.Text))
            {
                Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must not be lower than Min value.", "Inventory exceeded minimum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GlobalInv.inventory.UpdateProduct(InventoryHome.productID, productSelected);
                this.Close();
            }
        }
    }
}
