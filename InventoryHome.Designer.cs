
namespace InventoryApp
{
    partial class InventoryHome
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
            this.PartSearchBTN = new System.Windows.Forms.Button();
            this.ProdDelete = new System.Windows.Forms.Button();
            this.ProdMod = new System.Windows.Forms.Button();
            this.ProdAdd = new System.Windows.Forms.Button();
            this.PartDelete = new System.Windows.Forms.Button();
            this.PartMod = new System.Windows.Forms.Button();
            this.PartAdd = new System.Windows.Forms.Button();
            this.ProdSearchBTN = new System.Windows.Forms.Button();
            this.PartSearchTXT = new System.Windows.Forms.TextBox();
            this.ProdSearchTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.PartGrid = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PartSearchBTN
            // 
            this.PartSearchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchBTN.Location = new System.Drawing.Point(378, 59);
            this.PartSearchBTN.Name = "PartSearchBTN";
            this.PartSearchBTN.Size = new System.Drawing.Size(92, 44);
            this.PartSearchBTN.TabIndex = 0;
            this.PartSearchBTN.Text = "Search";
            this.PartSearchBTN.UseVisualStyleBackColor = true;
            this.PartSearchBTN.Click += new System.EventHandler(this.PartSearchBTN_Click);
            // 
            // ProdDelete
            // 
            this.ProdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDelete.Location = new System.Drawing.Point(1660, 504);
            this.ProdDelete.Name = "ProdDelete";
            this.ProdDelete.Size = new System.Drawing.Size(92, 44);
            this.ProdDelete.TabIndex = 1;
            this.ProdDelete.Text = "Delete";
            this.ProdDelete.UseVisualStyleBackColor = true;
            this.ProdDelete.Click += new System.EventHandler(this.ProdDelete_Click);
            // 
            // ProdMod
            // 
            this.ProdMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdMod.Location = new System.Drawing.Point(1546, 504);
            this.ProdMod.Name = "ProdMod";
            this.ProdMod.Size = new System.Drawing.Size(92, 44);
            this.ProdMod.TabIndex = 2;
            this.ProdMod.Text = "Modify";
            this.ProdMod.UseVisualStyleBackColor = true;
            this.ProdMod.Click += new System.EventHandler(this.ProdMod_Click);
            // 
            // ProdAdd
            // 
            this.ProdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdAdd.Location = new System.Drawing.Point(1429, 504);
            this.ProdAdd.Name = "ProdAdd";
            this.ProdAdd.Size = new System.Drawing.Size(92, 44);
            this.ProdAdd.TabIndex = 3;
            this.ProdAdd.Text = "Add";
            this.ProdAdd.UseVisualStyleBackColor = true;
            this.ProdAdd.Click += new System.EventHandler(this.ProdAdd_Click);
            // 
            // PartDelete
            // 
            this.PartDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDelete.Location = new System.Drawing.Point(770, 504);
            this.PartDelete.Name = "PartDelete";
            this.PartDelete.Size = new System.Drawing.Size(92, 44);
            this.PartDelete.TabIndex = 4;
            this.PartDelete.Text = "Delete";
            this.PartDelete.UseVisualStyleBackColor = true;
            this.PartDelete.Click += new System.EventHandler(this.PartDelete_Click);
            // 
            // PartMod
            // 
            this.PartMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMod.Location = new System.Drawing.Point(656, 504);
            this.PartMod.Name = "PartMod";
            this.PartMod.Size = new System.Drawing.Size(92, 44);
            this.PartMod.TabIndex = 5;
            this.PartMod.Text = "Modify";
            this.PartMod.UseVisualStyleBackColor = true;
            this.PartMod.Click += new System.EventHandler(this.PartMod_Click);
            // 
            // PartAdd
            // 
            this.PartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartAdd.Location = new System.Drawing.Point(540, 504);
            this.PartAdd.Name = "PartAdd";
            this.PartAdd.Size = new System.Drawing.Size(92, 44);
            this.PartAdd.TabIndex = 6;
            this.PartAdd.Text = "Add";
            this.PartAdd.UseVisualStyleBackColor = true;
            this.PartAdd.Click += new System.EventHandler(this.PartAdd_Click);
            // 
            // ProdSearchBTN
            // 
            this.ProdSearchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdSearchBTN.Location = new System.Drawing.Point(1268, 59);
            this.ProdSearchBTN.Name = "ProdSearchBTN";
            this.ProdSearchBTN.Size = new System.Drawing.Size(92, 44);
            this.ProdSearchBTN.TabIndex = 7;
            this.ProdSearchBTN.Text = "Search";
            this.ProdSearchBTN.UseVisualStyleBackColor = true;
            this.ProdSearchBTN.Click += new System.EventHandler(this.ProdSearchBTN_Click);
            // 
            // PartSearchTXT
            // 
            this.PartSearchTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchTXT.Location = new System.Drawing.Point(476, 66);
            this.PartSearchTXT.Name = "PartSearchTXT";
            this.PartSearchTXT.Size = new System.Drawing.Size(386, 30);
            this.PartSearchTXT.TabIndex = 8;
            this.PartSearchTXT.TextChanged += new System.EventHandler(this.PartSearchTXT_TextChanged);
            // 
            // ProdSearchTXT
            // 
            this.ProdSearchTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdSearchTXT.Location = new System.Drawing.Point(1366, 66);
            this.ProdSearchTXT.Name = "ProdSearchTXT";
            this.ProdSearchTXT.Size = new System.Drawing.Size(386, 30);
            this.ProdSearchTXT.TabIndex = 9;
            this.ProdSearchTXT.TextChanged += new System.EventHandler(this.ProdSearchTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(942, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parts";
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AutoGenerateColumns = false;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.ProductGrid.DataSource = this.productBindingSource;
            this.ProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductGrid.Location = new System.Drawing.Point(947, 127);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.RowHeadersWidth = 51;
            this.ProductGrid.RowTemplate.Height = 24;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.ShowEditingIcon = false;
            this.ProductGrid.Size = new System.Drawing.Size(805, 371);
            this.ProductGrid.TabIndex = 13;
            this.ProductGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductGrid_CellMouseClick);
            this.ProductGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductGrid_DataBindingComplete);
            // 
            // PartGrid
            // 
            this.PartGrid.AllowUserToAddRows = false;
            this.PartGrid.AllowUserToDeleteRows = false;
            this.PartGrid.AutoGenerateColumns = false;
            this.PartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.PartGrid.DataSource = this.partBindingSource;
            this.PartGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PartGrid.Location = new System.Drawing.Point(57, 127);
            this.PartGrid.MultiSelect = false;
            this.PartGrid.Name = "PartGrid";
            this.PartGrid.RowHeadersWidth = 51;
            this.PartGrid.RowTemplate.Height = 24;
            this.PartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartGrid.ShowEditingIcon = false;
            this.PartGrid.Size = new System.Drawing.Size(805, 371);
            this.PartGrid.TabIndex = 14;
            this.PartGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartGrid_CellDoubleClick);
            this.PartGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PartGrid_CellMouseClick);
            this.PartGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PartGrid_DataBindingComplete);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1661, 648);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 44);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PartID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(InventoryApp.Part);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InventoryApp.Product);
            // 
            // InventoryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 716);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PartGrid);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdSearchTXT);
            this.Controls.Add(this.PartSearchTXT);
            this.Controls.Add(this.ProdSearchBTN);
            this.Controls.Add(this.PartAdd);
            this.Controls.Add(this.PartMod);
            this.Controls.Add(this.PartDelete);
            this.Controls.Add(this.ProdAdd);
            this.Controls.Add(this.ProdMod);
            this.Controls.Add(this.ProdDelete);
            this.Controls.Add(this.PartSearchBTN);
            this.Name = "InventoryHome";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PartSearchBTN;
        private System.Windows.Forms.Button ProdDelete;
        private System.Windows.Forms.Button ProdMod;
        private System.Windows.Forms.Button ProdAdd;
        private System.Windows.Forms.Button PartDelete;
        private System.Windows.Forms.Button PartMod;
        private System.Windows.Forms.Button PartAdd;
        private System.Windows.Forms.Button ProdSearchBTN;
        private System.Windows.Forms.TextBox PartSearchTXT;
        private System.Windows.Forms.TextBox ProdSearchTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.DataGridView PartGrid;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource partBindingSource;
    }
}