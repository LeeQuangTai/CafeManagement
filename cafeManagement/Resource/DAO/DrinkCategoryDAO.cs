using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using cafeManagement.Resource.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cafeManagement.Resource.DAO
{
    public class DrinkCategoryDAO
    {
        private static DrinkCategoryDAO instance;
        public static DrinkCategoryDAO Instance
        {
            get { if (instance == null) instance = new DrinkCategoryDAO(); return instance; }
            private set { DrinkCategoryDAO.instance = value; }
        }
        private DrinkCategoryDAO() { }
        public List<DrinkCategory> GetDrinkCategories()
        {
            List<DrinkCategory> drinkCategories = new List<DrinkCategory>();
            string query = "select * from DrinkCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DrinkCategory drinkCategory = new DrinkCategory(item);
                drinkCategories.Add(drinkCategory);
            }
            return drinkCategories;
        }
    }
}
