using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Williams_CRUD
{
    public partial class Default : Form
    {
        Product productForm = new Product();
        Customer customerForm = new Customer();
        public Default()
        {
            InitializeComponent();
        }

        private void Products_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            productForm.ShowDialog();
            this.Show();
        }

        private void Customer_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerForm.ShowDialog();
            this.Show();
        }
    }
}
