namespace WindowsFormsApp5.screens.product
{
    partial class Products
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
            this.dataview = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activesubstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouse2DataSet = new WindowsFormsApp5.WareHouse2DataSet();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouseDataSet = new WindowsFormsApp5.WareHouseDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storehouseDataSet = new WindowsFormsApp5.StorehouseDataSet();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storehouseDataSet1 = new WindowsFormsApp5.StorehouseDataSet1();
            this.productsTableAdapter = new WindowsFormsApp5.StorehouseDataSetTableAdapters.productsTableAdapter();
            this.productsTableAdapter1 = new WindowsFormsApp5.StorehouseDataSet1TableAdapters.productsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.productsTableAdapter2 = new WindowsFormsApp5.WareHouseDataSetTableAdapters.ProductsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productsTableAdapter3 = new WindowsFormsApp5.WareHouse2DataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouse2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.AutoGenerateColumns = false;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.activesubstanceDataGridViewTextBoxColumn});
            this.dataview.DataSource = this.productsBindingSource3;
            this.dataview.Location = new System.Drawing.Point(12, 56);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.Size = new System.Drawing.Size(494, 240);
            this.dataview.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activesubstanceDataGridViewTextBoxColumn
            // 
            this.activesubstanceDataGridViewTextBoxColumn.DataPropertyName = "Active_substance";
            this.activesubstanceDataGridViewTextBoxColumn.HeaderText = "Active_substance";
            this.activesubstanceDataGridViewTextBoxColumn.Name = "activesubstanceDataGridViewTextBoxColumn";
            this.activesubstanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.wareHouse2DataSet;
            // 
            // wareHouse2DataSet
            // 
            this.wareHouse2DataSet.DataSetName = "WareHouse2DataSet";
            this.wareHouse2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.wareHouseDataSet;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "WareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.storehouseDataSet;
            // 
            // storehouseDataSet
            // 
            this.storehouseDataSet.DataSetName = "StorehouseDataSet";
            this.storehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "products";
            this.productsBindingSource1.DataSource = this.storehouseDataSet1;
            // 
            // storehouseDataSet1
            // 
            this.storehouseDataSet1.DataSetName = "StorehouseDataSet1";
            this.storehouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "All products we have";
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(47, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "SearchProduct";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(321, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "AddProduct";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsTableAdapter3
            // 
            this.productsTableAdapter3.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.Resize += new System.EventHandler(this.Products_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouse2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private StorehouseDataSet storehouseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private StorehouseDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private StorehouseDataSet1 storehouseDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private StorehouseDataSet1TableAdapters.productsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private WareHouseDataSet wareHouseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private WareHouseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activesubstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private WareHouse2DataSet wareHouse2DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private WareHouse2DataSetTableAdapters.ProductsTableAdapter productsTableAdapter3;
    }
}