﻿using cafeManagement.Resource.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafeManagement.Resource.DAO
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
                return bill.BillID;
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
            string query = "UPDATE dbo.Bill SET BillStatus = 1, "  + "Discount = " + discount + " WHERE BillID = " + billID;
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
        }

    }
}
