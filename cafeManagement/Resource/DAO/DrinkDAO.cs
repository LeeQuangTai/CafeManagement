using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using cafeManagement.Resource.DTO;
using cafeManagement.Resource.DAO;

namespace cafeManagement.Resource.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static DrinkDAO Instance
        {
            get { if (instance == null) instance = new DrinkDAO(); return instance; }
            private set { DrinkDAO.instance = value; }
        }
        private DrinkDAO() { }
        public List<Drink> GetListDrinkByCategoryID(string drinkCategoryID)
        {
            List<Drink> listDrink = new List<Drink>();
            string query = "exec sp_GetListDrinkByDrinkCategory @DrinkCategoryID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { drinkCategoryID });
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }


        public List<Drink> GetListDrink()
        {
            List<Drink> list = new List<Drink>();

            string query = "select * from Drink";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }

            return list;
        }
        public DataTable getData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {

                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        public void addM(string ID, string Name)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {
                connection.Open();

                string query = "INSERT INTO dbo.DrinkCategory (DrinkCategoryID, DrinkCategoryName) VALUES (@DrinkCategoryID, @DrinkCategoryName)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DrinkCategoryID", ID);
                command.Parameters.AddWithValue("@DrinkCategoryName", Name);
                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có!");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void addSP(string IDMon, string TenMon, string TenDM, int GiaBan)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionSTR))
            {
                connection.Open();

                string query = "INSERT INTO dbo.Drink (DrinkID, DrinkCategoryID, DrinkName, UnitPrice) VALUES (@DrinkID, @DrinkCategoryID, @DrinkName, @UnitPrice)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DrinkID", IDMon);
                command.Parameters.AddWithValue("@DrinkCategoryID", TenMon);
                command.Parameters.AddWithValue("@DrinkName", TenDM);
                command.Parameters.AddWithValue("@UnitPrice", GiaBan);
                try
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sản phẩm nàyyyyyyyyyyyyyyy!");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }


}



