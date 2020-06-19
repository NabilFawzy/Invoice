using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void txtInvNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            txtInvDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbStore.Focus();
            cmbStore.Select();
            cmbStore.SelectAll();
        }

        private void txtInvDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInvDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtInvNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtInvDate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtInvDate.ContextMenu = new ContextMenu();
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {

        }
    }
}
