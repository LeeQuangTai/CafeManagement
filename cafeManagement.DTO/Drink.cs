using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.DTO
{
    public class Drink
    {
        public Drink(string drinkID, string drinkCategoryID, string drinkName, float unitPrice, int status)
        {
            this.DrinkID = drinkID;
            this.DrinkCategoryID = drinkCategoryID;
            this.DrinkName = drinkName;
            this.UnitPrice = unitPrice;
            this.Status = status;
        }
        public Drink(DataRow row)
        {
            this.DrinkID = row["drinkID"].ToString();
            this.DrinkCategoryID = row["drinkCategoryID"].ToString();
            this.DrinkName = row["drinkName"].ToString();
            this.UnitPrice = (float)Convert.ToDouble((row["unitPrice"].ToString()));
            //this.Status = Convert.ToInt32(row["status"]);
        }
        private string drinkID;
        public string DrinkID
        {
            get { return drinkID; }
            set { drinkID = value; }
        }
        private string drinkCategoryID;
        public string DrinkCategoryID
        {
            get { return drinkCategoryID; }
            set { drinkCategoryID = value; }
        }
        private string drinkName;
        public string DrinkName
        {
            get { return drinkName; }
            set { drinkName = value; }
        }
        private float unitPrice;
        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
