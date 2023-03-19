using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Resource.DTO
{
    public class BillInfo
    {
        private int billInfoID;
        public int BillInfoID
        {
            get { return billInfoID; }
            set { billInfoID = value; }
        }
        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        private string drinkID;
        public string DrinkID
        {
            get { return drinkID; }
            set { drinkID = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public BillInfo(int billInfoID, int billID, string drinklID, int quantity)
        {
            this.BillInfoID = billInfoID;
            this.BillID = billID;
            this.DrinkID = drinkID;
            this.Quantity = quantity;
        }
        public BillInfo(DataRow row)
        {
            this.BillInfoID = (int)row["billInfoID"];
            this.BillID = (int)row["billID"];
            this.DrinkID = row["drinkID"].ToString();
            this.Quantity = (int)row["quantity"];
        }
    }
}
