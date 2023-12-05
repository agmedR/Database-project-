namespace WindowsFormsApp5.screens.product
{
    partial class SearchProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.storehouseDataSet2 = new WindowsFormsApp5.StorehouseDataSet2();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp5.StorehouseDataSet2TableAdapters.productsTableAdapter();
            this.wareHouseDataSet1 = new WindowsFormsApp5.WareHouseDataSet1();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new WindowsFormsApp5.WareHouseDataSet1TableAdapters.ProductsTableAdapter();
            this.wareHouse2DataSet2 = new WindowsFormsApp5.WareHouse2DataSet2();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter2 = new WindowsFormsApp5.WareHouse2DataSet2TableAdapters.ProductsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activesubstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouse2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_ID";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(169, 13);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(134, 31);
            this.txtpname.TabIndex = 2;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(443, 13);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 31);
            this.txtpid.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(229, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataview
            // 
            this.dataview.AutoGenerateColumns = false;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.activesubstanceDataGridViewTextBoxColumn,
            this.companyCodeDataGridViewTextBoxColumn});
            this.dataview.DataSource = this.productsBindingSource2;
            this.dataview.Location = new System.Drawing.Point(17, 108);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(540, 232);
            this.dataview.TabIndex = 9;
            // 
            // storehouseDataSet2
            // 
            this.storehouseDataSet2.DataSetName = "StorehouseDataSet2";
            this.storehouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.storehouseDataSet2;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // wareHouseDataSet1
            // 
            this.wareHouseDataSet1.DataSetName = "WareHouseDataSet1";
            this.wareHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.wareHouseDataSet1;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // wareHouse2DataSet2
            // 
            this.wareHouse2DataSet2.DataSetName = "WareHouse2DataSet2";
            this.wareHouse2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.wareHouse2DataSet2;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
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
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // activesubstanceDataGridViewTextBoxColumn
            // 
            this.activesubstanceDataGridViewTextBoxColumn.DataPropertyName = "Active_substance";
            this.activesubstanceDataGridViewTextBoxColumn.HeaderText = "Active_substance";
            this.activesubstanceDataGridViewTextBoxColumn.Name = "activesubstanceDataGridViewTextBoxColumn";
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "Company_Code";
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "Company_Code";
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 352);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SearchProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchProducts";
            this.Load += new System.EventHandler(this.SearchProducts_Load);
            this.Resize += new System.EventHandler(this.SearchProducts_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouse2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataview;
        private StorehouseDataSet2 storehouseDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private StorehouseDataSet2TableAdapters.productsTableAdapter productsTableAdapter;
        private WareHouseDataSet1 wareHouseDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private WareHouseDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private WareHouse2DataSet2 wareHouse2DataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private WareHouse2DataSet2TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activesubstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
    }
}