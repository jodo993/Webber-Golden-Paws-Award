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

namespace Webber_Golden_Paws_Award
{
    public partial class RegistrationForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\josep\Documents\WebberGoldenPawsAwardDatabase.mdf;Integrated Security = True; Connect Timeout = 30");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string grade = gradeComboBox.Text;
            int code = int.Parse(codeTextBox.Text);
            string username = usernameTextBox.Text;

            if (firstName != "" && lastName != "" && grade != "" && code > 0 && username != "")
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into RegistrationData (FirstName, LastName, Grade, Code, Username)" +
                                      "values ('" + firstName + "','" + lastName + "','" + grade + "','" + code + "','" + username + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successful.");
            }
        }
    }
}
