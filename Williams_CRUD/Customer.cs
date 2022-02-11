using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Williams_CRUD
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            getCustomerData();
        }

        private void getCustomerData()
        {
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand command = new SqlCommand("CustomerSummary", conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                CustomerGridView.DataSource = dt;
            }
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDTB.Text);
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand command = new SqlCommand("populateTextBoxes", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                titleTB.Text = dataReader.GetValue(1).ToString();
                firstNameTB.Text = dataReader.GetValue(2).ToString();
                middleNameTB.Text = dataReader.GetValue(3).ToString();
                lastNameTB.Text = dataReader.GetValue(4).ToString();
                suffixTB.Text = dataReader.GetValue(5).ToString();
                companyNameTB.Text = dataReader.GetValue(6).ToString();
                salesPersonTB.Text = dataReader.GetValue(7).ToString();
                emailAddressTB.Text = dataReader.GetValue(8).ToString();
                phoneTB.Text = dataReader.GetValue(9).ToString();
                addressTypeTB.Text = dataReader.GetValue(10).ToString();
                addressLine1TB.Text = dataReader.GetValue(11).ToString();
                addressLine2TB.Text = dataReader.GetValue(12).ToString();
                cityTB.Text = dataReader.GetValue(13).ToString();
                stateProvinceTB.Text = dataReader.GetValue(14).ToString();
                countryRegionTB.Text = dataReader.GetValue(15).ToString();
                postalCodeTB.Text = dataReader.GetValue(16).ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (IDTB.Text == null || IDTB.Text == "")
            {
                MessageBox.Show("Invalid ID");
                return;
            }
            else
            {
                int ID = Convert.ToInt32(IDTB.Text);
                using (SqlConnection conn = new SqlConnection(db.getConnString()))
                {
                    SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                getCustomerData();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title;
            string firstName;
            string middleName;
            string lastName;
            string suffix;
            string companyName;
            string salesPerson;
            string emailAddress;
            string phone;
            string addressType;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string countryRegion;
            string postalCode;

            title = titleTB.Text;
            firstName = firstNameTB.Text;
            middleName = middleNameTB.Text;
            lastName = lastNameTB.Text;
            suffix = suffixTB.Text;
            companyName = companyNameTB.Text;
            salesPerson = salesPersonTB.Text;
            emailAddress = emailAddressTB.Text;
            phone = phoneTB.Text;
            addressType = addressTypeTB.Text;
            addressLine1 = addressLine1TB.Text;
            addressLine2 = addressLine2TB.Text;
            city = cityTB.Text;
            stateProvince = stateProvinceTB.Text;
            countryRegion = countryRegionTB.Text;
            postalCode = postalCodeTB.Text;

            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@firstname", firstName);
                cmd.Parameters.AddWithValue("@middlename", middleName);
                cmd.Parameters.AddWithValue("@lastname", lastName);
                cmd.Parameters.AddWithValue("@suffix", suffix);
                cmd.Parameters.AddWithValue("@companyname", companyName);
                cmd.Parameters.AddWithValue("@salesperson", salesPerson);
                cmd.Parameters.AddWithValue("@emailaddress", emailAddress);
                cmd.Parameters.AddWithValue("@phone", phone);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerAddressAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addressline1", addressLine1);
                cmd.Parameters.AddWithValue("@addressline2", addressLine2);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@stateprovince", stateProvince);
                cmd.Parameters.AddWithValue("@countryregion", countryRegion);
                cmd.Parameters.AddWithValue("@postalcode", postalCode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("addNewCustomerAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addresstype", addressType);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            getCustomerData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDTB.Text);
            int addressID = Convert.ToInt32(IDTB.Text);
            string title;
            string firstName;
            string middleName;
            string lastName;
            string suffix;
            string companyName;
            string salesPerson;
            string emailAddress;
            string phone;
            string addressType;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string countryRegion;
            string postalCode;

            title = titleTB.Text;
            firstName = firstNameTB.Text;
            middleName = middleNameTB.Text;
            lastName = lastNameTB.Text;
            suffix = suffixTB.Text;
            companyName = companyNameTB.Text;
            salesPerson = salesPersonTB.Text;
            emailAddress = emailAddressTB.Text;
            phone = phoneTB.Text;
            addressType = addressTypeTB.Text;
            addressLine1 = addressLine1TB.Text;
            addressLine2 = addressLine2TB.Text;
            city = cityTB.Text;
            stateProvince = stateProvinceTB.Text;
            countryRegion = countryRegionTB.Text;
            postalCode = postalCodeTB.Text;

            using (SqlConnection conn = new SqlConnection(db.getConnString()))
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@firstname", firstName);
                cmd.Parameters.AddWithValue("@middlename", middleName);
                cmd.Parameters.AddWithValue("@lastname", lastName);
                cmd.Parameters.AddWithValue("@suffix", suffix);
                cmd.Parameters.AddWithValue("@companyname", companyName);
                cmd.Parameters.AddWithValue("@salesperson", salesPerson);
                cmd.Parameters.AddWithValue("@emailaddress", emailAddress);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addressline1", addressLine1);
                cmd.Parameters.AddWithValue("@addressline2", addressLine2);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@stateprovince", stateProvince);
                cmd.Parameters.AddWithValue("@countryregion", countryRegion);
                cmd.Parameters.AddWithValue("@postalcode", postalCode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            getCustomerData();
        }
    }
}
