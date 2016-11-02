namespace AtticaBillingSystem
{
    partial class Attca_BillPrint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.txt_TransactionID = new System.Windows.Forms.TextBox();
            this.lbl_TransactionID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Print);
            this.groupBox1.Controls.Add(this.txt_TransactionID);
            this.groupBox1.Controls.Add(this.lbl_TransactionID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(447, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(489, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Print.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(201, 101);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(92, 38);
            this.btn_Print.TabIndex = 16;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // txt_TransactionID
            // 
            this.txt_TransactionID.Location = new System.Drawing.Point(172, 28);
            this.txt_TransactionID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TransactionID.MaxLength = 50;
            this.txt_TransactionID.Name = "txt_TransactionID";
            this.txt_TransactionID.Size = new System.Drawing.Size(225, 22);
            this.txt_TransactionID.TabIndex = 1;
            // 
            // lbl_TransactionID
            // 
            this.lbl_TransactionID.AutoSize = true;
            this.lbl_TransactionID.Location = new System.Drawing.Point(55, 32);
            this.lbl_TransactionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TransactionID.Name = "lbl_TransactionID";
            this.lbl_TransactionID.Size = new System.Drawing.Size(100, 17);
            this.lbl_TransactionID.TabIndex = 0;
            this.lbl_TransactionID.Text = "Transaction ID";
            // 
            // Attca_BillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1805, 902);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Attca_BillPrint";
            this.Text = "Print Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TransactionID;
        private System.Windows.Forms.Label lbl_TransactionID;
        private System.Windows.Forms.Button btn_Print;
    }
}