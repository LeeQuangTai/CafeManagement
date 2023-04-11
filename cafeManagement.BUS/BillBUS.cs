using cafeManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cafeManagement.BUS
{
    public class BillBUS
    {

        private static BillBUS instance;
        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return instance; }
            private set { BillBUS.instance = value; }
        }
        public BillBUS() { }
        public int GetCountProductBetweenDayAndDay(string first, string after)
        {
            return BillDAO.Instance.GetCountProductBetweenDayAndDay(first, after);
        }
        public int GetCountBillBetweenDayAndDay(string first,string after)
        {
            return BillDAO.Instance.GetCountBillBetweenDayAndDay(first, after);
        }
        public int GetTotalSaleBetweenDayAndDay(string first ,string after)
        {
            return BillDAO.Instance.GetTotalSaleBetweenDayAndDay(first , after);    
        }
        public DataTable GetInfoBillStatistics(string first, string after)
        {
            return BillDAO.Instance.GetInfoBillStatistics(first, after);   
        }
    }
}
