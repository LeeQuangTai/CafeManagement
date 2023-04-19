using cafeManagement.DAO;
using cafeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cafeManagement.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetBillIDuncheck(string tableID)
        {
            string query = "exec GetBillIDuncheck @TableID , 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tableID });
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                int? billID = (int?)bill.BillID;
                return (int)billID;
            }
            return -1;
        }
        public void InsertBill(string tableID)
        {
            string query = "sp_InsertBill @TableID ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tableID });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(BillID) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int billID, int discount)
        {
            string query = "UPDATE dbo.Bill SET BillStatus = 1, " + "Discount = " + discount + ", DateCheckOut= getdate() WHERE BillID = " + billID;
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
        }
        public List<ViewBill> GetListViewBill(int billID, string dateCheckIn)
        {
            List<ViewBill> bills = new List<ViewBill>();
            string query = "exec sp_GetListViewBill @BillID , @DateCheckIn ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { billID, dateCheckIn });
            foreach (DataRow item in data.Rows)
            {
                ViewBill bill = new ViewBill(item);
                bills.Add(bill);
            }
            return bills;
        }
        public List<Bill> GetListBill(string dateXuatHoaDon)
        {
            List<Bill> bills = new List<Bill>();
            string query = "exec sp_GetListBillID @DateCheckIn ";
            Console.WriteLine(query);
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { dateXuatHoaDon });
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                bills.Add(bill);
            }
            return bills;
        }
        public decimal GetTotalMoney(int billID)
        {
            string query = "exec sp_GetTotalMoney @BillID ";
            decimal total = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { billID });
            return total;
        }
        
        public int GetCountProductBetweenDayAndDay(string first, string after)
        {
            string query = "select sum(Quantity) as [count] from BillInFo, bill where BillInfo.BillID = bill.BillID and DateCheckin >= '" + first + "'  and DateCheckin <= '" + after + "'";
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int GetCountBillBetweenDayAndDay(string first, string after)
        {
            string query = "select count(BillID) as [count] from dbo.Bill where DateCheckin >= '" + first + "'  and DateCheckin <= '" + after + "'";
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int GetTotalSaleBetweenDayAndDay(string first, string after)
        {
            string newQuery = "select Convert(int,sum(d.UnitPrice * bi.Quantity) - sum(convert(int,d.UnitPrice) * bi.Quantity * b.Discount/100)) AS [sum] " +
                "              from BillInfo bi, bill b,drink d , TableManagement t " +
                "              where bi.BillID = b.BillID and d.DrinkID = bi.DrinkID and t.TableID = b.TableID " +
                "              and DateCheckin >= '" + first + "'  and DateCheckin <= '" + after + "'";
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(newQuery);
            }
            catch (Exception) 
            { 
                return 0; 
            }
        }
        public DataTable GetInfoBillStatistics(string first, string after)
        {
            string query = "select b.BillID,b.TableID, b.DateCheckIn, b.DateCheckOut ,sum(quantity) as TotalDrinks  ,b.Discount,sum(Quantity * convert(int,d.UnitPrice) - Quantity * convert(int,d.UnitPrice)*Discount / 100) as TotalSales from BillInfo bi ,Drink d, bill b where bi.DrinkID = d.DrinkID and bi.BillID = b.BillID " +
                "and DateCheckin >= '" + first + "'  and DateCheckin <= '" + after + "' group by b.BillID, b.TableID, b.DateCheckIn, b.DateCheckOut, b.Discount";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
