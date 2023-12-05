namespace WindowsFormsApp5.screens.exports
{
    partial class Exports
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
            this.txtquan = new System.Windows.Forms.TextBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtphid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(156, 140);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(139, 31);
            this.txtquan.TabIndex = 25;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(156, 74);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(139, 31);
            this.txtpid.TabIndex = 24;
            // 
            // txtphid
            // 
            this.txtphid.Location = new System.Drawing.Point(156, 8);
            this.txtphid.Name = "txtphid";
            this.txtphid.Size = new System.Drawing.Size(139, 31);
            this.txtphid.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "product_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pharmacy_Id";
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.Gray;
            this.but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but.Location = new System.Drawing.Point(100, 261);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(114, 38);
            this.but.TabIndex = 19;
            this.but.Text = "Done";
            this.but.UseVisualStyleBackColor = false;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 31);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // Exports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 311);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquan);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtphid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Exports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exports";
            this.Resize += new System.EventHandler(this.Exports_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtphid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}