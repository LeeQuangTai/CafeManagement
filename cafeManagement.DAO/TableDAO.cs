﻿using cafeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
        private set { instance = value; }
        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;
        private TableDAO() { }

        public void TransferTable(string tableID1, string tableID2)
        {
            DataProvider.Instance.ExecuteQuery(" sp_Transfer @TableID1 , @TableID2", new object[] { tableID1, tableID2 });
        }


        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
    
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableManagement");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public Table LoadTableNotBill(string tableID)
        {
            string query = "Update dbo.TableManagement Set Status = N'Trống' where Status = N'Có người' and TableID = " + tableID;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tableID });
            return new Table(data.Rows[0]);

        }
    }
}