using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Resource.DTO
{
    public class Order
    {
        public Order(string drinkName, float unitPrice, int quantity, float totalPrice = 0)
        {
            this.DrinkName = drinkName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;

        }
        public Order(DataRow row)
        {
            this.DrinkName = row["drinkName"].ToString();
            this.UnitPrice = (float)Convert.ToDouble((row["unitPrice"].ToString()));
            this.Quantity = (int)row["quantity"];
            this.TotalPrice = (float)Convert.ToDouble((row["totalPrice"].ToString()));
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
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
