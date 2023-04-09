using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.DTO
{
    public class ViewBill
    {
        public ViewBill(int billID, int billInfoID, string drinkName, float unitPrice, int quantity, string tableID, DateTime? dateCheckin, float totalPrice = 0)
        {
            this.BillID = billID;
            this.DrinkName = drinkName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;
            this.DateCheckin = dateCheckin;
            this.TableID = tableID;
        }
        public ViewBill(DataRow row)
        {
            this.BillID = (int)row["billID"];
            this.DrinkName = row["drinkName"].ToString();
            this.UnitPrice = (float)Convert.ToDouble((row["unitPrice"].ToString()));
            this.Quantity = (int)row["quantity"];
            this.TotalPrice = (float)Convert.ToDouble((row["totalPrice"].ToString()));
            this.DateCheckin = (DateTime?)row["dateCheckin"];
            this.TableID = row["tableID"].ToString();
        }
        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
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
        private DateTime? dateCheckin;
        public DateTime? DateCheckin
        {
            get { return dateCheckin; }
            set { dateCheckin = value; }
        }
        private string tableID;
        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

    }
}
