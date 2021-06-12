namespace InventoryApp
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.Outsourced = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.PInventory = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.PPrice = new System.Windows.Forms.Label();
            this.PMax = new System.Windows.Forms.Label();
            this.PMin = new System.Windows.Forms.Label();
            this.PMachine = new System.Windows.Forms.Label();
            this.P_ID = new System.Windows.Forms.TextBox();
            this.P_Name = new System.Windows.Forms.TextBox();
            this.P_Inventory = new System.Windows.Forms.TextBox();
            this.P_Price = new System.Windows.Forms.TextBox();
            this.P_Max = new System.Windows.Forms.TextBox();
            this.P_Min = new System.Windows.Forms.TextBox();
            this.P_ManID = new System.Windows.Forms.TextBox();
            this.PSave = new System.Windows.Forms.Button();
            this.PCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHouse
            // 
            this.InHouse.AccessibleName = "InHouse";
            this.InHouse.AutoSize = true;
            this.InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouse.Location = new System.Drawing.Point(256, 13);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(113, 29);
            this.InHouse.TabIndex = 1;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // Outsourced
            // 
            this.Outsourced.AccessibleName = "Outsourced";
            this.Outsourced.AutoSize = true;
            this.Outsourced.Checked = true;
            this.Outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outsourced.Location = new System.Drawing.Point(472, 13);
            this.Outsourced.Name = "Outsourced";
            this.Outsourced.Size = new System.Drawing.Size(135, 29);
            this.Outsourced.TabIndex = 2;
            this.Outsourced.TabStop = true;
            this.Outsourced.Text = "Outsourced";
            this.Outsourced.UseVisualStyleBackColor = true;
            this.Outsourced.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChanged);
            // 
            // ID
            // 
            this.ID.AccessibleName = "ID";
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(219, 83);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 25);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PInventory
            // 
            this.PInventory.AccessibleName = "PInventory";
            this.PInventory.AutoSize = true;
            this.PInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInventory.Location = new System.Drawing.Point(158, 170);
            this.PInventory.Name = "PInventory";
            this.PInventory.Size = new System.Drawing.Size(92, 25);
            this.PInventory.TabIndex = 4;
            this.PInventory.Text = "Inventory";
            // 
            // PName
            // 
            this.PName.AccessibleName = "PName";
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(186, 128);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(64, 25);
            this.PName.TabIndex = 5;
            this.PName.Text = "Name";
            // 
            // PPrice
            // 
            this.PPrice.AccessibleName = "PPrice";
            this.PPrice.AutoSize = true;
            this.PPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice.Location = new System.Drawing.Point(147, 215);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(103, 25);
            this.PPrice.TabIndex = 6;
            this.PPrice.Text = "Price/Cost";
            // 
            // PMax
            // 
            this.PMax.AccessibleName = "PMax";
            this.PMax.AutoSize = true;
            this.PMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMax.Location = new System.Drawing.Point(200, 263);
            this.PMax.Name = "PMax";
            this.PMax.Size = new System.Drawing.Size(50, 25);
            this.PMax.TabIndex = 7;
            this.PMax.Text = "Max";
            // 
            // PMin
            // 
            this.PMin.AccessibleName = "PMin";
            this.PMin.AutoSize = true;
            this.PMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMin.Location = new System.Drawing.Point(421, 263);
            this.PMin.Name = "PMin";
            this.PMin.Size = new System.Drawing.Size(44, 25);
            this.PMin.TabIndex = 8;
            this.PMin.Text = "Min";
            // 
            // PMachine
            // 
            this.PMachine.AccessibleName = "PMachine";
            this.PMachine.AutoSize = true;
            this.PMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMachine.Location = new System.Drawing.Point(96, 313);
            this.PMachine.Name = "PMachine";
            this.PMachine.Size = new System.Drawing.Size(154, 25);
            this.PMachine.TabIndex = 9;
            this.PMachine.Text = "Company Name";
            this.PMachine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // P_ID
            // 
            this.P_ID.AccessibleName = "P_ID";
            this.P_ID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.P_ID.BackColor = System.Drawing.SystemColors.Window;
            this.P_ID.Enabled = false;
            this.P_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_ID.Location = new System.Drawing.Point(256, 86);
            this.P_ID.Name = "P_ID";
            this.P_ID.Size = new System.Drawing.Size(351, 30);
            this.P_ID.TabIndex = 10;
            // 
            // P_Name
            // 
            this.P_Name.AccessibleName = "P_Name";
            this.P_Name.BackColor = System.Drawing.Color.Red;
            this.P_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Name.Location = new System.Drawing.Point(256, 132);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(351, 30);
            this.P_Name.TabIndex = 11;
            this.P_Name.TextChanged += new System.EventHandler(this.P_Name_TextChanged);
            // 
            // P_Inventory
            // 
            this.P_Inventory.AccessibleName = "P_Inventory";
            this.P_Inventory.BackColor = System.Drawing.Color.Red;
            this.P_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Inventory.Location = new System.Drawing.Point(256, 174);
            this.P_Inventory.Name = "P_Inventory";
            this.P_Inventory.Size = new System.Drawing.Size(351, 30);
            this.P_Inventory.TabIndex = 12;
            this.P_Inventory.TextChanged += new System.EventHandler(this.P_Inventory_TextChanged);
            // 
            // P_Price
            // 
            this.P_Price.AccessibleName = "P_Price";
            this.P_Price.BackColor = System.Drawing.Color.Red;
            this.P_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Price.Location = new System.Drawing.Point(256, 215);
            this.P_Price.Name = "P_Price";
            this.P_Price.Size = new System.Drawing.Size(351, 30);
            this.P_Price.TabIndex = 13;
            this.P_Price.TextChanged += new System.EventHandler(this.P_Price_TextChanged);
            // 
            // P_Max
            // 
            this.P_Max.AccessibleName = "P_Max";
            this.P_Max.BackColor = System.Drawing.Color.Red;
            this.P_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Max.Location = new System.Drawing.Point(256, 263);
            this.P_Max.Name = "P_Max";
            this.P_Max.Size = new System.Drawing.Size(140, 30);
            this.P_Max.TabIndex = 14;
            this.P_Max.TextChanged += new System.EventHandler(this.P_Max_TextChanged);
            // 
            // P_Min
            // 
            this.P_Min.AccessibleName = "P_Min";
            this.P_Min.BackColor = System.Drawing.Color.Red;
            this.P_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Min.Location = new System.Drawing.Point(482, 263);
            this.P_Min.Name = "P_Min";
            this.P_Min.Size = new System.Drawing.Size(125, 30);
            this.P_Min.TabIndex = 15;
            this.P_Min.TextChanged += new System.EventHandler(this.P_Min_TextChanged);
            // 
            // P_ManID
            // 
            this.P_ManID.AccessibleName = "P_ManID";
            this.P_ManID.BackColor = System.Drawing.Color.Red;
            this.P_ManID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_ManID.Location = new System.Drawing.Point(256, 310);
            this.P_ManID.Name = "P_ManID";
            this.P_ManID.Size = new System.Drawing.Size(351, 30);
            this.P_ManID.TabIndex = 16;
            this.P_ManID.TextChanged += new System.EventHandler(this.P_ManID_TextChanged);
            // 
            // PSave
            // 
            this.PSave.AccessibleName = "PSave";
            this.PSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSave.Location = new System.Drawing.Point(399, 352);
            this.PSave.Name = "PSave";
            this.PSave.Size = new System.Drawing.Size(80, 36);
            this.PSave.TabIndex = 17;
            this.PSave.Text = "Save";
            this.PSave.UseVisualStyleBackColor = true;
            this.PSave.Click += new System.EventHandler(this.PSave_Click);
            // 
            // PCancel
            // 
            this.PCancel.AccessibleName = "PCancel";
            this.PCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCancel.Location = new System.Drawing.Point(502, 352);
            this.PCancel.Name = "PCancel";
            this.PCancel.Size = new System.Drawing.Size(105, 36);
            this.PCancel.TabIndex = 18;
            this.PCancel.Text = "Cancel";
            this.PCancel.UseVisualStyleBackColor = true;
            this.PCancel.Click += new System.EventHandler(this.PCancel_Click);
            // 
            // AddPart
            // 
            this.AccessibleName = "AddPart";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCancel);
            this.Controls.Add(this.PSave);
            this.Controls.Add(this.P_ManID);
            this.Controls.Add(this.P_Min);
            this.Controls.Add(this.P_Max);
            this.Controls.Add(this.P_Price);
            this.Controls.Add(this.P_Inventory);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.P_ID);
            this.Controls.Add(this.PMachine);
            this.Controls.Add(this.PMin);
            this.Controls.Add(this.PMax);
            this.Controls.Add(this.PPrice);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PInventory);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Outsourced);
            this.Controls.Add(this.InHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton Outsourced;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PInventory;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PPrice;
        private System.Windows.Forms.Label PMax;
        private System.Windows.Forms.Label PMin;
        private System.Windows.Forms.Label PMachine;
        private System.Windows.Forms.TextBox P_ID;
        private System.Windows.Forms.TextBox P_Inventory;
        private System.Windows.Forms.TextBox P_Price;
        private System.Windows.Forms.TextBox P_Max;
        private System.Windows.Forms.TextBox P_Min;
        private System.Windows.Forms.TextBox P_ManID;
        private System.Windows.Forms.Button PSave;
        private System.Windows.Forms.Button PCancel;
        private System.Windows.Forms.TextBox P_Name;
    }
}