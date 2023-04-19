using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.DTO
{
    public class DrinkCategory
    {
        public DrinkCategory(string drinkCategoryID, string drinkCategoryName)
        {
            this.DrinkCategoryID = drinkCategoryID;
            this.DrinkCategoryName = drinkCategoryName;
        }
        public DrinkCategory(DataRow row)
        {
            this.DrinkCategoryID = row["drinkCategoryID"].ToString();
            this.DrinkCategoryName = row["drinkCategoryName"].ToString();
        }
        private string drinkCategoryID;
        public string DrinkCategoryID
        {
            get { return drinkCategoryID; }
            set { drinkCategoryID = value; }
        }
        private string drinkCategoryName;
        public string DrinkCategoryName
        {
            get { return drinkCategoryName; }
            set { drinkCategoryName = value; }
        }
    }
}
