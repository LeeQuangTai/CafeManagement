using cafeManagement.Resource.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafeManagement.Resource.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int billID)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "exec sp_GetListBillInfo @BillID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { billID });

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int billID, string drinkID, int quantity)
        {

            DataProvider.Instance.ExecuteQuery("EXEC sp_InsertBillInfo @BillID , @DrinkID , @Quantity ", new object[] { billID, drinkID, quantity });
        }
    }
}
