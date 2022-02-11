using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Williams_CRUD
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            getProductData();
        }
        private void getProductData() 
        {
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand command = new SqlCommand("ProductSummary", conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                ProductGridView.DataSource = dt;
            }
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
