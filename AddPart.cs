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
    public partial class AddPart : Form
    {
        Outsourced newOutPart;
        InHouse newInPart;
        private int NewPartID = GlobalInv.inventory.AllParts.Count;
        private int partId;
        private string PartName;
        private decimal PartPrice;
        private int PartInStock;
        private int PartMin;
        private int PartMax;
        private int PartMachID;
        private string Company;
        private bool isInvInt,isMinInt, isMaxInt, isMachIDInt, isPriceDec;
        private bool mustBeInt = false;


        public AddPart()
        {
            InitializeComponent();
        }

        //Set variables_________________________________________________________________
        private void P_Name_TextChanged(object sender, EventArgs e)
        {
            P_Name.BackColor = Color.White;
                PartName = P_Name.Text;
        }

        private void P_Inventory_TextChanged(object sender, EventArgs e)
        {
            P_Inventory.BackColor = Color.White;
            if(int.TryParse(P_Inventory.Text, out int result))
            {
                PartInStock = result;
                isInvInt = true;
            }
            else
            {
                isInvInt = false;
            }
        }


        private void P_ManID_TextChanged(object sender, EventArgs e)
        {
            P_ManID.BackColor = Color.White;
            if (mustBeInt == true)
            {
                if(int.TryParse(P_ManID.Text, out int result) && P_ManID.Text != null)
                {
                    PartMachID = result;
                    isMachIDInt = true;
                }
                else { isMachIDInt = false;
                }
            }
            else { Company = P_ManID.Text; }
        }

        private void P_Max_TextChanged(object sender, EventArgs e)
        {
            P_Max.BackColor = Color.White;
            if(int.TryParse(P_Max.Text, out int result))
            {
                PartMax = result;
                isMaxInt = true;
            }
            else { isMaxInt = false;
            }
        }

        private void P_Min_TextChanged(object sender, EventArgs e)
        {
            P_Min.BackColor = Color.White;
            if(int.TryParse(P_Min.Text, out int result) && P_Min.Text != null)
            {
                PartMin = result;
                isMinInt = true;
            }
            else
            {
                isMinInt = false;
            }
        }

        private void P_Price_TextChanged(object sender, EventArgs e)
        {
            P_Price.BackColor = Color.White;
            if (decimal.TryParse(P_Price.Text, out decimal result))
            {
                PartPrice = result;
                isPriceDec = true;
            }
            else
            {
                isPriceDec = false;
            }
        }
        //________________________________________________________________________________________

        //set button behavior_____________________________________________________________________
        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    PMachine.Text = "Machine ID";
                    mustBeInt = true;
                }
            }
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    PMachine.Text = "Company Name";
                    mustBeInt = false;
                }
            }
        }

        private void PSave_Click(object sender, EventArgs e)
        {
            if(PartName == null || PartName == "")
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
            else if (mustBeInt ==true && isMachIDInt == false)
            {
                MessageBox.Show("Machine ID requires a number (example: 123)", "Needs Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_ManID.BackColor = Color.Red;
                return;
            }else if(mustBeInt == false && Company == null)
            {
                MessageBox.Show("Please enter a Company Name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_ManID.BackColor = Color.Red;
                return;
            }
            else if (PartMin > PartMax)
            {
                MessageBox.Show("Max must be of lower value than Min", "Min too high", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Max.BackColor = Color.Red;
                return;
            } else if(isPriceDec == false)
            {
                MessageBox.Show("Price must contain a number value.", "Needs Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P_Price.BackColor = Color.Red;
                return;
            }else if(PartInStock > PartMax)
            {
                P_Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must not be higher than Max value.", "Inventory max exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(PartInStock < PartMin)
            {
                P_Inventory.BackColor = Color.Red;
                MessageBox.Show("Inventory must not be lower than Min value.", "Inventory minimum exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                partId = GlobalInv.inventory.PartID();
                var partIDSearch = from p in GlobalInv.inventory.AllParts
                                   where partId == p.PartID
                                   select p;
                if (partIDSearch.Any())
                {
                    partId++;
                }
                if (mustBeInt == true)
                {
                    newInPart = new InHouse(PartMachID, partId, PartName, PartPrice, PartInStock, PartMin, PartMax);
                    GlobalInv.inventory.AddPart(newInPart);
                    this.Close();
                }
                else
                {
                    newOutPart = new Outsourced(Company, NewPartID, PartName, PartPrice, PartInStock, PartMin, PartMax);
                    GlobalInv.inventory.AddPart(newOutPart);
                    this.Close();
                }
            }
        }

        private void PCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        //__________________________________________________________________________________________________________________
       
    }
}
