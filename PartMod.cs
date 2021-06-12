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
    public partial class PartMod : Form
    {
        private Outsourced updatedOutPart;
        private InHouse updatedInPart;
        private string name, compName;
        private int pInv, min, max, mID;
        private decimal price;
        private bool isInvInt, isMinInt, isMaxInt, isMachIDInt, isPriceDec;
        private bool mustBeInt = false;



        public PartMod()
        {
            InitializeComponent();

           
            // setting initial values______________________________________________
            var partFound = GlobalInv.inventory.LookupPart(InventoryHome.partID);

            P_ID.Text = InventoryHome.partID.ToString();
            P_Name.Text = partFound.Name;
            P_Inventory.Text = partFound.InStock.ToString();
            P_Min.Text = partFound.Min.ToString();
            P_Max.Text = partFound.Max.ToString();
            P_Price.Text = partFound.Price.ToString();
            if(partFound is InHouse)
            {
                InHouse a = (InHouse)partFound;
                P_ManID.Text = a.MachineID.ToString();
                InHouse.Checked = true;
                isMachIDInt = true;
                mID = int.Parse(P_ManID.Text);
            }else
            {
                Outsourced b = (Outsourced)partFound;
                P_ManID.Text = b.CompanyName;
                Outsourced.Checked = true;
                compName = P_ManID.Text;
            }
            if (InHouse.Checked == true)
            {
                mustBeInt = true;
                PMachine.Text = "Machine ID";
            }
            else
            {
                PMachine.Text = "Company Name";
            }
            name = P_Name.Text;
            price = decimal.Parse(P_Price.Text);
            pInv = int.Parse(P_Inventory.Text);
            min = int.Parse(P_Min.Text);
            max = int.Parse(P_Max.Text);
            
            //_____________________________________________________________________
        }

        //set changed values_______________________________________________________
        private void P_Price_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(P_Price.Text, out decimal result))
            {
                price = result;
                isPriceDec = true;
            }
            else
            {
                isPriceDec = false;
            }
        }

        private void P_Max_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(P_Max.Text, out int result))
            {
                max = result;
                isMaxInt = true;
            }
            else { isMaxInt = false; }
        }

        private void P_Min_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(P_Min.Text, out int result))
            {
                min = result;
                isMinInt = true;
            }
            else
            {
                isMinInt = false;
            }
        }

        

        private void P_ManID_TextChanged(object sender, EventArgs e)
        {
            if(InHouse.Checked == true)
            {
                if(int.TryParse(P_ManID.Text, out int result))
                {
                    isMachIDInt = true;
                    mID = int.Parse(P_ManID.Text);
                }
                else
                {
                    isMachIDInt = false;
                }
            }
            else
            {
                compName = P_ManID.Text;
            }
        }

        private void P_Name_TextChanged(object sender, EventArgs e)
        {
            name = P_Name.Text;
        }

        private void P_Inventory_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(P_Inventory.Text, out int result))
            {
                pInv = result;
                isInvInt = true;
            }
            else
            {
                isInvInt = false;
            }

        }
        //_______________________________________________________________________________________________________________

        //Button behaviour_______________________________________________________________________________________________
        private void Save_Click(object sender, EventArgs e)
        {
            if (name == null || name == "")
            {
                MessageBox.Show("Part must have a name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Name.BackColor = Color.Red;
                return;
            }
            else if (isInvInt == false)
            {
                MessageBox.Show("Inventory requires a number (example: 123).", "Needs Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Inventory.BackColor = Color.Red;
                return;
            }
            else if (isMaxInt == false)
            {
                MessageBox.Show("Max requires a number (example: 123)", "Needs Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Max.BackColor = Color.Red;
                return;
            }
            else if (isMinInt == false)
            {
                MessageBox.Show("Min requires a number (example: 123)", "Needs Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Min.BackColor = Color.Red;
                return;
            }
            else if (mustBeInt == true && isMachIDInt == false)
            {
                MessageBox.Show("Machine ID requires a number (example: 123)", "Needs Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_ManID.BackColor = Color.Red;
                return;
            }
            else if (mustBeInt == false && compName == null)
            {
                MessageBox.Show("Please enter a Company Name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_ManID.BackColor = Color.Red;
                return;
            }
            else if (min > max)
            {
                MessageBox.Show("Max must be of lower value than Min", "Min too high", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Max.BackColor = Color.Red;
                return;
            }
            else if (isPriceDec == false)
            {
                MessageBox.Show("Price must contain a number value.", "Needs Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Price.BackColor = Color.Red;
                return;
            }
            else
            {
                if (mustBeInt == true)
                {
                    updatedInPart = new InHouse(mID, int.Parse(P_ID.Text), name, price, pInv, min, max);
                    GlobalInv.inventory.UpdatePart(InventoryHome.partID, updatedInPart);
                    this.Close();
                }
                else
                {
                    updatedOutPart = new Outsourced(compName, int.Parse(P_ID.Text), name, price, pInv, min, max);
                    GlobalInv.inventory.UpdatePart(InventoryHome.partID, updatedOutPart);
                    this.Close();
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //_______________________________________________________________________________________________________________
    }
}
