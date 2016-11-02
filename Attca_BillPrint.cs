using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtticaBillingSystem
{
    public partial class Attca_BillPrint : Form
    {
        public int TransactionId = 0;
        public Attca_BillPrint(string branchCode, int TransactionID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            TransactionId = TransactionID;
            txt_TransactionID.Text = TransactionId.ToString();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            TransactionId = Convert.ToInt32(txt_TransactionID.Text);
            Attica_PrintEstimate objPrint = new Attica_PrintEstimate(TransactionId);
            objPrint.Show();
        }
    }
}
