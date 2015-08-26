
using System.Data;
using System.Data.SqlClient;


namespace lockpick
{
    static class Extensions
    {
        public static string useremail;
        public static string usersalt;

        public static void SetUserSalt(this SqlConnectionStringBuilder saltconnection)
        {
            using (var conn = new SqlConnection(saltconnection.ConnectionString))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "select PasswordSalt from dbo.aspnet_Membership where LoweredEmail = @Email";
                command.Parameters.AddWithValue("@Email", useremail);

                usersalt = command.ExecuteScalar().ToString();
            }
        }

        public static void SetUserEmail(this string email)
        {
            useremail = email;
        }

        public static string GetSalt(this string salt)
        {
            return usersalt;
        }

    }
}
                                        