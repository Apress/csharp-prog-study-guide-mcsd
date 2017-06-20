using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_13_Code_Challenges
{
    public partial class Login : Form
    {

        private static string connectionstring = @"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=DBHash;Integrated security=TRUE";
        public Login()
        {
            InitializeComponent();
        }
        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            // this is the value we will return
            int userId = 0;

            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand(@"SELECT [Userid],[Username],[Password],[UserGuid] FROM
                                    [DBHash].[dbo].[Users] WHERE Username=@Username", con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // dr.Read() = we found user(s) with matching username!

                    int dbUserId = Convert.ToInt32(dr["UserId"]);
                    string dbPassword = Convert.ToString(dr["Password"]);
                    string dbUserGuid = Convert.ToString(dr["UserGuid"]);

                    // Now we hash the UserGuid from the database with the password we wan't to check
                    // In the same way as when we saved it to the database in the first place. (see AddUser() function)
                    string hashedPassword = Registration.HashSHA512(password + dbUserGuid);
                    // if its correct password the result of the hash is the same as in the database
                    if (dbPassword == hashedPassword)
                        // The password is correct
                        userId = dbUserId;
                }
            }
            con.Close();
            // Return the user id which is 0 if we did not found a user.
            return userId;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg;
            int userId = GetUserIdByUsernameAndPassword(txtUserName.Text, txtPassword.Text);
            if (userId > 0)
            {
                // Now you can put users id in a session-variable or what you prefer
                // and redirect the user to the protected area of your website.
                msg = string.Format("Welcome, Your userId is : {0}", userId);
            }
            else
            {
                msg = "Wrong username or password";
            }
            MessageBox.Show(msg);
        }
    }
}
