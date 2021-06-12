
namespace InventoryApp
{
    partial class ModProd
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Inventory = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Can_Parts = new System.Windows.Forms.DataGridView();
            this.AssociatedParts = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Can_Parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "All candidate Parts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(572, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID";
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(377, 516);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(109, 30);
            this.Min.TabIndex = 36;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            // 
            // Max
            // 
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(155, 516);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(95, 30);
            this.Max.TabIndex = 35;
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(155, 434);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(287, 30);
            this.Price.TabIndex = 34;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.SystemColors.Window;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(155, 351);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(287, 30);
            this.Inventory.TabIndex = 33;
            this.Inventory.TextChanged += new System.EventHandler(this.Inventory_TextChanged);
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.SystemColors.Window;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(155, 271);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(287, 30);
            this.ProdName.TabIndex = 32;
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(155, 190);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(287, 30);
            this.ID.TabIndex = 31;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(1016, 38);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(333, 30);
            this.SearchText.TabIndex = 30;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(1255, 737);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 49);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(1102, 737);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 49);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1254, 654);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 48);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1254, 331);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 46);
            this.Add.TabIndex = 26;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(921, 30);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(89, 46);
            this.Search.TabIndex = 25;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Modify Product";
            // 
            // Can_Parts
            // 
            this.Can_Parts.AllowUserToAddRows = false;
            this.Can_Parts.AllowUserToDeleteRows = false;
            this.Can_Parts.AutoGenerateColumns = false;
            this.Can_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Can_Parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.Can_Parts.DataSource = this.partBindingSource;
            this.Can_Parts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Can_Parts.Location = new System.Drawing.Point(577, 97);
            this.Can_Parts.MultiSelect = false;
            this.Can_Parts.Name = "Can_Parts";
            this.Can_Parts.RowHeadersWidth = 51;
            this.Can_Parts.RowTemplate.Height = 24;
            this.Can_Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Can_Parts.Size = new System.Drawing.Size(771, 228);
            this.Can_Parts.TabIndex = 46;
            this.Can_Parts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Can_Parts_CellMouseClick);
            this.Can_Parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Can_Parts_DataBindingComplete);
            // 
            // AssociatedParts
            // 
            this.AssociatedParts.AllowUserToAddRows = false;
            this.AssociatedParts.AllowUserToDeleteRows = false;
            this.AssociatedParts.AutoGenerateColumns = false;
            this.AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.AssociatedParts.DataSource = this.partBindingSource1;
            this.AssociatedParts.Location = new System.Drawing.Point(576, 420);
            this.AssociatedParts.Name = "AssociatedParts";
            this.AssociatedParts.RowHeadersWidth = 51;
            this.AssociatedParts.RowTemplate.Height = 24;
            this.AssociatedParts.Size = new System.Drawing.Size(771, 228);
            this.AssociatedParts.TabIndex = 47;
            this.AssociatedParts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AssociatedParts_CellMouseClick);
            this.AssociatedParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AssociatedParts_DataBindingComplete);
            // 
            // partIDDataGridViewTextBoxColumn1
            // 
            this.partIDDataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn1.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.partIDDataGridViewTextBoxColumn1.Name = "partIDDataGridViewTextBoxColumn1";
            this.partIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            this.inStockDataGridViewTextBoxColumn1.Width = 125;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            this.minDataGridViewTextBoxColumn1.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            this.maxDataGridViewTextBoxColumn1.Width = 125;
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(InventoryApp.Part);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.Width = 125;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(InventoryApp.Part);
            // 
            // ModProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 802);
            this.Controls.Add(this.AssociatedParts);
            this.Controls.Add(this.Can_Parts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Name = "ModProd";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.Can_Parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Inventory;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Can_Parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridView AssociatedParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource partBindingSource1;
    }
}