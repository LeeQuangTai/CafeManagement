using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.CodeDom;

namespace cafeManagement.Resource.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        private string connectionSTR = "Data Source = LAPTOP-DHRETR9B\\;Initial Catalog=CafeManagement;Integrated Security=True";
        public string Connnection() { return connectionSTR; }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string userAccount, string displayName, string password, string accountType)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) 
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
                    
                    MessageBox.Show("Tài khoản đã có sẵn, vui lòng nhập lại tài khoản khác!") ;
                }
                finally
                {
                  connection.Close();
                }
            }

            return rowsAffected;
        }

        public int ExecuteNonQueryToEdit(string userName,string newUserName, string displayname, string password , string type)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string queryy = "update account set UserName = '" + newUserName + "',PassWord = '"+password+"',DisplayName = '"+displayname+"' , type = "+type+" where UserName = '"+userName+"'";
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
        public int ExecuteNonQueryToDelete(List<string> a)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                if (a.Count > 0)
                {
                    string queryy = "DELETE FROM account WHERE account.UserName = '" + a[0].ToString() + "';";
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


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
    
