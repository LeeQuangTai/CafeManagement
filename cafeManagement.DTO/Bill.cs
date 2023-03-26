using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.DTO
{
    public class Bill
    {

        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        private DateTime? dateCheckin;
        public DateTime? DateCheckin
        {
            get { return dateCheckin; }
            set { dateCheckin = value; }
        }
        private DateTime? dateCheckout;
        public DateTime? DateCheckout
        {
            get { return dateCheckout; }
            set { dateCheckout = value; }
        }
        private string tableID;
        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        private int billStatus;
        public int BillStatus
        {
            get { return billStatus; }
            set { billStatus = value; }
        }
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public Bill(int billID, DateTime? dateCheckin, DateTime? dateCheckout, string tableID, int billStatus, int discount = 0)
        {
            this.BillID = billID;
            this.DateCheckin = dateCheckin;
            this.DateCheckin = dateCheckin;
            this.TableID = tableID;
            this.BillStatus = billStatus;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.BillID = (int)row["billID"];
            this.DateCheckin = (DateTime?)row["dateCheckin"];
            var dateCheckoutTemp = row["dateCheckout"];
            if (dateCheckoutTemp.ToString() != "")
                this.DateCheckout = (DateTime?)dateCheckoutTemp;
            this.TableID = row["tableID"].ToString();
            this.BillStatus = (int)row["billStatus"];
            if(row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }

    }
}
