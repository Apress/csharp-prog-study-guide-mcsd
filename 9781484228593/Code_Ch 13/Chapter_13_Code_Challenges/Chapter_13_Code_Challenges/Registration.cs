using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_13_Code_Challenges
{
    public partial class Registration : Form
    {
        private static string connectionstring = @"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=DBHash;Integrated security=TRUE";
        public Registration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves Used in the Database
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        public static string AddUser(string username, string password)
        {

            // This function will add a user to our database

            // First create a new Guid for the user. This will be unique for each user
            Guid userGuid = System.Guid.NewGuid();
            string hashedPassword = HashSHA512(password + userGuid.ToString());

            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO [DBHash].[dbo].[Users]([Username],[Password],[UserGuid])
                                        VALUES(@Username,@Password,@UserGuid)", con))
                {
                    // Add the input as parameters to avoid sql-injections
                    // I'll explain later in this article.
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword); // store the hashed value
                    cmd.Parameters.AddWithValue("@UserGuid", userGuid); // store the Guid

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "ERROR";
            }
            return hashedPassword;
        }

        /// <summary>
        /// Hash password with SHA 512 algorithm
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>returns hashed password</returns>
        public static string HashSHA512(string password)
        {
            var sha1 = SHA512.Create();
            var inputBytes = Encoding.ASCII.GetBytes(password);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var item in hash)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string hashedValue = AddUser(txtUserName.Text, txtPassword.Text);
            if (hashedValue != "ERROR")
                MessageBox.Show("Hashed Value is: \n"+ hashedValue,"User is Registered");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
