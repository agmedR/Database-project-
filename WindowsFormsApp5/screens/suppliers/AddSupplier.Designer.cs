namespace WindowsFormsApp5.screens.suppliers
{
    partial class AddSupplier
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.but = new System.Windows.Forms.Button();
            this.txtconame = new System.Windows.Forms.TextBox();
            this.txtcoad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtccode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtscode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(200, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(219, 31);
            this.txtname.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(200, 86);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(219, 31);
            this.txtphone.TabIndex = 6;
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.Gray;
            this.but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but.Location = new System.Drawing.Point(371, 241);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(151, 38);
            this.but.TabIndex = 8;
            this.but.Text = "ADD";
            this.but.UseVisualStyleBackColor = false;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // txtconame
            // 
            this.txtconame.Location = new System.Drawing.Point(649, 15);
            this.txtconame.Name = "txtconame";
            this.txtconame.Size = new System.Drawing.Size(219, 31);
            this.txtconame.TabIndex = 0;
            // 
            // txtcoad
            // 
            this.txtcoad.Location = new System.Drawing.Point(649, 86);
            this.txtcoad.Name = "txtcoad";
            this.txtcoad.Size = new System.Drawing.Size(219, 31);
            this.txtcoad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "CompanyName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CompanyAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Company_Code";
            // 
            // txtccode
            // 
            this.txtccode.Location = new System.Drawing.Point(649, 157);
            this.txtccode.Name = "txtccode";
            this.txtccode.Size = new System.Drawing.Size(219, 31);
            this.txtccode.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supplier_Code";
            // 
            // txtscode
            // 
            this.txtscode.Location = new System.Drawing.Point(200, 163);
            this.txtscode.Name = "txtscode";
            this.txtscode.Size = new System.Drawing.Size(219, 31);
            this.txtscode.TabIndex = 14;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 308);
            this.Controls.Add(this.txtscode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtccode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcoad);
            this.Controls.Add(this.txtconame);
            this.Controls.Add(this.but);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSupplier";
            this.Resize += new System.EventHandler(this.AddSupplier_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.TextBox txtcoad;
        private System.Windows.Forms.TextBox txtconame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtccode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtscode;
    }
}