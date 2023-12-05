namespace WindowsFormsApp5.screens.imports
{
    partial class Imports
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
            this.but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.Gray;
            this.but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but.Location = new System.Drawing.Point(106, 259);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(114, 38);
            this.but.TabIndex = 9;
            this.but.Text = "Done";
            this.but.UseVisualStyleBackColor = false;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supplier_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "product_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "quantity";
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(159, 22);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(139, 31);
            this.txtsid.TabIndex = 13;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(159, 80);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(139, 31);
            this.txtpid.TabIndex = 14;
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(159, 138);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(139, 31);
            this.txtquan.TabIndex = 15;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(159, 199);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(139, 31);
            this.dtp.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date";
            // 
            // Imports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquan);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Imports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imports";
            this.Resize += new System.EventHandler(this.Imports_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
    }
}