using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class popup : Form
    {
        public string Result { get; private set; } = "Cancel";
        public popup()
        {
            InitializeComponent();
        }

        private void popup_Load(object sender, EventArgs e)
        {
            
        }
        //Creating the connection string
        public static string getConnStr()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Directory.GetParent(Directory.GetParent(currentDirectory).Parent.FullName).FullName;
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectRootDirectory}Database1.mdf;Integrated Security=True";
            return connectionString;
        }
        //Creating the connection string object
        SqlConnection conn = new SqlConnection(getConnStr());
        
        public void button1_Click(object sender, EventArgs e)
        {
            Result = "Confirm";
            this.Close();

            //Declaring variables to add data
            string EmployeeName = txtEmployeeName.Text;
            string EmployeeID = txtEmployeeID.Text;
            string Reason = txtReason.Text;

            //Creating the SQL query
            string query = $"INSERT INTO Shift Applying ('{EmployeeName}','{EmployeeID}','{Reason}');";

            //Creating the SQL command
            SqlCommand cmd = new SqlCommand(query,conn);

            //Executing the SQL command
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SQL Command Execution Successful", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = "Cancel";
            this.Close();

            //Declaring variables
            string EmployeeName = txtEmployeeName.Text;
            string EmployeeID = txtEmployeeID.Text;
            string Reason = txtReason.Text;



            //Creating the SQL query
            string query = $"DELETE FROM [Shift Applying] WHERE [Employee Name] = '{EmployeeName}' OR [Employee ID] = '{EmployeeID}' OR [Reason] = '{Reason}'";

            // Creating the SQL command
            SqlCommand cmd = new SqlCommand(query, conn);

            // Executing the SQL command
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found for the specified criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

