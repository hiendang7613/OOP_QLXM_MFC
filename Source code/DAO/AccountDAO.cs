using QLXM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM.DAO
{
    class AccountDAO 
    {
        private static AccountDAO accountDAO = null;
        SqlParameter UsernamePmt;
        SqlParameter PassworddPmt;

        private AccountDAO()
        {
            UsernamePmt = new SqlParameter();
            UsernamePmt.ParameterName = "@Username";
            UsernamePmt.SqlDbType = SqlDbType.VarChar;

            PassworddPmt = new SqlParameter();
            PassworddPmt.ParameterName = "@Passwordd";
            PassworddPmt.SqlDbType = SqlDbType.VarChar;
        }

        public static AccountDAO getInstance()
        {
            if (accountDAO == null)
            {
                accountDAO = new AccountDAO();
            }
            return accountDAO;
        }

        SqlConnection connection;

        public bool Check(string username, string password)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    UsernamePmt.Value = username;
                    PassworddPmt.Value = password;

                    string queryString = "SELECT * FROM Account WHERE Username = @Username AND Passwordd = @Passwordd ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(UsernamePmt);
                    command.Parameters.Add(PassworddPmt);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool Update(Account t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    UsernamePmt.Value = t.Username;
                    PassworddPmt.Value = t.Password;

                    string queryString = "UPDATE Account SET Passwordd = @Passwordd WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(UsernamePmt);
                    command.Parameters.Add(PassworddPmt);
                    int count = command.ExecuteNonQuery();
                    if (count < 1)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }

    }
}
