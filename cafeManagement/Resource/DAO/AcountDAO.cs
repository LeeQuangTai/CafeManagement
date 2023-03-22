using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.Resource.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "EXEC sp_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public int EditAccount(string userName, string newUserName, string displayname, string password, int type)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {
                connection.Open();
                string queryy = "update account set UserName = '" + newUserName + "',PassWord = '" + password + "',DisplayName = '" + displayname + "' , type = " + type + " where UserName = '" + userName + "'";
                SqlCommand command = new SqlCommand(queryy, connection);

                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.ToString());
                }
                finally
                {
                    connection.Close();
                }
                return rowsAffected;
            }
        }
       
        public int addAccount(string userAccount, string displayName, string password, string accountType)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {
                connection.Open();

                string query = "INSERT INTO dbo.Account (UserName, DisplayName, Password, Type) VALUES (@UserName, @DisplayName, @Password, @Type)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userAccount);
                command.Parameters.AddWithValue("@DisplayName", displayName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Type", accountType);
                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản đã có sẵn, vui lòng nhập lại tài khoản khác!");
                }
                finally
                {
                    connection.Close();
                }
            }

            return rowsAffected;
        }
        public int DeleteAccount(string a)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {
                connection.Open();
                if (a != null)
                {
                    string queryy = "DELETE FROM account WHERE account.UserName = '" + a + "';";
                    SqlCommand command = new SqlCommand(queryy, connection);
                    try
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Xoá không thành công!");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else return 0;
                return rowsAffected;
            }
        }

    }
}