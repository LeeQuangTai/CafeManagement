using cafeManagement.DAO;
using cafeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.BUS
{
    public class BillBUS
    {

        private static BillBUS instance;

        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return BillBUS.instance; }
            private set { BillBUS.instance = value; }
        }

        private BillBUS() { }

        public void LoadListViewBill(TextBox cbb, DataGridView dgvHoaDon, int billID, string dateCheckIn)
        {
            List<ViewBill> viewBills = BillDAO.Instance.GetListViewBill(billID, dateCheckIn);
            dgvHoaDon.DataSource = viewBills;
            for (int i = 0; i < dgvHoaDon.ColumnCount; i++)
            {
                dgvHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
            loadTongTien(cbb, billID);
        }

        //public List<Order> GetListBillID(DateTime? dateCheckIn)
        //{
        //    return BillDAO.Instance.GetListBillID(dateCheckIn);
        //}

        public void LoadListBIllID(ComboBox cbb, string dateXuatHoaDon)
        {

            List<Bill> bills = BillDAO.Instance.GetListBill(dateXuatHoaDon);
            if (bills.Count > 0)
        {
                cbb.DataSource = bills;
                cbb.DisplayMember = "BillID";
        }
            else
        {
                cbb.DataSource = null;
            }
        }

        public void loadTongTien(TextBox txt, int billID)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            txt.Text = BillDAO.Instance.GetTotalMoney(billID).ToString("c", culture);
        }
        public int GetCountProductBetweenDayAndDay(string first, string after)
        {
            return BillDAO.Instance.GetCountProductBetweenDayAndDay(first, after);
        }
        public int GetCountBillBetweenDayAndDay(string first, string after)
        {
            return BillDAO.Instance.GetCountBillBetweenDayAndDay(first, after);
        }
        public int GetTotalSaleBetweenDayAndDay(string first, string after)
        {
            return BillDAO.Instance.GetTotalSaleBetweenDayAndDay(first, after);
        }
        public DataTable GetInfoBillStatistics(string first, string after)
        {
            return BillDAO.Instance.GetInfoBillStatistics(first, after);
        }
    }
}
