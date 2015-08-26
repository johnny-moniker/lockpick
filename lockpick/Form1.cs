using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace lockpick
{
    public partial class frmLockpicka : Form
    {
        private SqlConnectionStringBuilder  ConnstrBuilder;
        private string                      HashedPassword;

        public frmLockpicka()
        {
            InitializeComponent();
        }

        public void btnClickForm(object sender, EventArgs e)
        {
            var buttonID = ((Button) sender).Name;
            switch (buttonID)
            {
                case "btnSubmitPWChange":
                    SetConnectionString();
                    txtASPMember.Text.SetUserEmail();
                    ConnstrBuilder.SetUserSalt();
                    SetHashedPassword(txtASPMemberPass.Text, "".GetSalt());
                    StoreNewPassword();
                    break;
                case "btnTestConnection":
                    SetConnectionString();
                    try
                    {
                        using (var conn = new SqlConnection(ConnstrBuilder.ConnectionString))
                        {
                            conn.Open();
                            lblServerStatus.Text = "connection success... enter new password";
                            ToggleConnectionPanel();
                        }
                    }
                    catch (Exception ex)
                    {
                        lblServerStatus.Text = ex.Message;
                    }
                    break;
            }
        }

        private void SetConnectionString()
        {
            if (chkboxConnection.Checked)
            {
                ConnstrBuilder.ConnectionString = txtFullConnection.Text;
                return;
            }

            ConnstrBuilder = new SqlConnectionStringBuilder
            {
                DataSource      = txtServerPath.Text,
                InitialCatalog  = txtInitialCatalog.Text,
                UserID          = txtServerUserID.Text,
                Password        = txtServerPassword.Text,
            };
        }

        //hashes password using the useraccount's salt
        private void SetHashedPassword(string pwd, string slt)
        {
            //encodes (unicode byte array) of supplied password
            var passwordArray   = Encoding.Unicode.GetBytes(pwd);

            //creates a byte array from a base 64 salt value
            var saltArray       = Convert.FromBase64String(slt);

            //initializes an empty array of size x (x = the cumulative length of the password and salt arrays) 
            var saltedPassArray = new byte[saltArray.Length + passwordArray.Length];

            //copies the byte arrays to the empty array in the following order: salt, password
            saltArray       .CopyTo(saltedPassArray, 0);
            passwordArray   .CopyTo(saltedPassArray, saltArray.Length);

            //initializes an sha1 encryption object
            var sha = new SHA1CryptoServiceProvider();

            //converts byte array to a base 64 string and returns that value
            HashedPassword = Convert.ToBase64String(sha.ComputeHash(saltedPassArray));
        }

        //writes newly hashed password to database
        private void StoreNewPassword()
        {
            try
            {
                using (var connection = new SqlConnection(ConnstrBuilder.ConnectionString))
                {
                    connection.Open();
                    var cmdStorePassword = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "UPDATE aspnet_Membership SET Password=@hashedPwd WHERE LoweredEmail=@email;",
                        Connection = connection
                    };
                    cmdStorePassword.Parameters.AddWithValue("@email", txtASPMember.Text);
                    cmdStorePassword.Parameters.AddWithValue("@hashedPwd", HashedPassword);
                    cmdStorePassword.ExecuteNonQuery();
                }
                MessageBox.Show("Password was successfully changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            
        }

        private void chkboxConnection_CheckedChanged(object sender, EventArgs e)
        {
            var checkstate = ((CheckBox) sender).Checked;
            txtFullConnection.Enabled   = checkstate;
            txtInitialCatalog.Enabled   = !checkstate;
            txtServerPassword.Enabled   = !checkstate;
            txtServerPath.Enabled       = !checkstate;
            txtServerUserID.Enabled     = !checkstate;

        }

        private void ToggleConnectionPanel()
        {
            bool enableConnection = btnTestConnection.Text.Equals("change connection");

            chkboxConnection.Checked  = !enableConnection;
            txtFullConnection.Enabled = !enableConnection;
            txtInitialCatalog.Enabled =  enableConnection;
            txtServerPassword.Enabled =  enableConnection;
            txtServerPath.Enabled     =  enableConnection;
            txtASPMember.Enabled      = !enableConnection;
            txtASPMemberPass.Enabled  = !enableConnection;
            btnSubmitPWChange.Enabled = !enableConnection;

            btnTestConnection.Text = enableConnection ? "test connection" : "change connection";
        }

        private void frmLockpicka_Load(object sender, EventArgs e)
        {

        }
    }
}
