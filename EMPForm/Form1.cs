using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleProject;
using CIS3680;
using System.Data.SqlClient;

namespace EMPForm
{
    public partial class Form1 : Form
    {
        private Customer myCustomer;
        private BindingSource bSource;



        public Customer myCustomer1
        {
            get
            {
                return myCustomer;
            }

            set
            {
                myCustomer = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            myCustomer = new Customer();

            
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            RetrieveData();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SaveData()
        {
            bool idTaken = true;

            myCustomer.CustomerId = CheckInteger(IDTextBox.Text);
            myCustomer.Name = CheckString(NameTextBox.Text);
            myCustomer.Email = CheckString(EmailTextBox.Text);
            myCustomer.DateOfBirth = DateTimePicker.Value;
            myCustomer.IsAlumnum = CheckBoxSelected(AlumnumCheck.SelectedIndex);

            try
            {
                idTaken = FindSQLID(myCustomer.CustomerId);
            }
            catch (SQLException e)
            {
                Console.WriteLine(e.Message);
            }

            if(idTaken)
            {
                MessageBox.Show("That ID is taken. Please enter a new ID.");
            }
            else
            {
                SqlConnection conn = OpenSQLConnection();
                SaveSQLData(conn);

                ClearForm();
                RefreshData();
            }
        
        }

        private void RetrieveData()
        {
            bool isAlumnum = myCustomer.IsAlumnum;

            IDTextBox.Text = myCustomer.CustomerId.ToString();
            NameTextBox.Text = myCustomer.Name.ToString();
            DateTimePicker.Value = myCustomer.DateOfBirth;
            EmailTextBox.Text = myCustomer.Email.ToString();

            if(isAlumnum)
            {
                AlumnumCheck.SetItemChecked(0, true);
                AlumnumCheck.SetItemChecked(1, false);
            } else
            {
                AlumnumCheck.SetItemChecked(0, false);
                AlumnumCheck.SetItemChecked(1, true);
            }

            Age.Text = myCustomer.CurrentAge.ToString();
        }


        private void ClearForm()
        {
            IDTextBox.Clear();
            NameTextBox.Clear();
            DateTimePicker.Value = DateTime.Now;
            EmailTextBox.Clear();
            AlumnumCheck.SetItemChecked(0, false);
            AlumnumCheck.SetItemChecked(1, false);
            Age.Text = '0'.ToString();
           
        }

        private double CheckDouble(string input)
        {
            double doubleReturned;

            if (Double.TryParse(input, out doubleReturned))
            {
                return doubleReturned;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a decimal.");
            }

            return doubleReturned;
        }

        private int CheckInteger(string input)
        {
            int integerReturned;

            if (Int32.TryParse(input, out integerReturned))
            {
                return integerReturned;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a number.");
            }

            return integerReturned;
        }

        private string CheckString(string input)
        {
            if(!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid string.");
            }

            return input;
        }

        private bool CheckBoxSelected(int selection)
        {
            if(selection == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private SqlConnection OpenSQLConnection()
        {

            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EMPForm\EMPForm\Customers.mdf;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(csb.ConnectionString);
            conn.Open();
            Console.WriteLine(conn.State);
            return conn;
        }

        private void SaveSQLData(SqlConnection conn)
        {
            string query = "INSERT INTO CustomerData (Id, Name, Email, Date_of_Birth, Is_Alumnum, Current_Age) " +
                    "VALUES (@Id, @Name, @Email, @Date_of_Birth, @Is_Alumnum, @Current_Age)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@Id", myCustomer.CustomerId);
                cmd.Parameters.AddWithValue("@Name", myCustomer.Name);
                cmd.Parameters.AddWithValue("@Email", myCustomer.Email);
                cmd.Parameters.AddWithValue("@Date_of_Birth", myCustomer.DateOfBirth);
                cmd.Parameters.AddWithValue("@Is_Alumnum", myCustomer.IsAlumnum);
                cmd.Parameters.AddWithValue("@Current_Age", myCustomer.CurrentAge);

                Console.WriteLine(conn.State);
                int rowsAffected = cmd.ExecuteNonQuery();
                ValidateSQLInsert(rowsAffected);

                conn.Close();
            }
        }

        private void ValidateSQLInsert(int result)
        {
            if(result > 0)
            {
                MessageBox.Show("Record inserted successfully");
            }
            else
            {
                MessageBox.Show("Record not inserted successfully");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.CustomerData' table. You can move, or remove it, as needed.
            this.customerDataTableAdapter.Fill(this.customersDataSet.CustomerData);

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            RefreshSQLData();
            CustomerDataGrid.DataSource = bSource;
            CustomerDataGrid.Refresh();
            CustomerDataGrid.Update();
        }

        private void RefreshSQLData()
        {
            SqlConnection conn = OpenSQLConnection();
            string query = "SELECT * FROM CustomerData";

            //create an OleDbDataAdapter to execute the query
            SqlDataAdapter dAdapter = new SqlDataAdapter(query, conn);

            //create a command builder
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(dAdapter);

            //create a DataTable to hold the query results
            DataTable dTable = new DataTable();

            //fill the DataTable
            dAdapter.Fill(dTable);


            //BindingSource to sync DataTable and DataGridView
            bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;


            //set the DataGridView DataSource
            CustomerDataGrid.DataSource = bSource;

            conn.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CustomerData;";

            SqlConnection conn = OpenSQLConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();
        }

        private bool FindSQLID(int id)
        {
            string query = "SELECT * FROM CustomerData WHERE Id =" + id + ";";

            Console.WriteLine(query);

            SqlConnection conn = OpenSQLConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dataReader = cmd.ExecuteReader();

            if(dataReader.HasRows)
            {
                throw new SQLException("Record already exists");
            }
            else
            {
                return false;
            }    
        }
    }
}
