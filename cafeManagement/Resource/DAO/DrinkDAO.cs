using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using cafeManagement.Resource.DTO;

namespace cafeManagement.Resource.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static DrinkDAO Instance 
        {   get { if (instance == null) instance = new DrinkDAO(); return instance; }
            private set { DrinkDAO.instance = value; }
        }
        private DrinkDAO() { }
        public List<Drink> GetListDrinkByCategoryID( string drinkCategoryID)
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

    }
}
