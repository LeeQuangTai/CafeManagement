using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using cafeManagement.BUS;
namespace cafeManagement
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
            LoadStatistics();

        }

        private void afterDate_ValueChanged(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {
            LoadStatistics();
        }
        void LoadStatistics()
        {

            var firstDateStr = firstDate.Value.Month + "/" + firstDate.Value.Day + "/" + firstDate.Value.Year;
            var afterDateStr = afterDate.Value.Month + "/" + afterDate.Value.Day + "/" + afterDate.Value.Year;
            if (firstDate.Value > afterDate.Value)
            {
                Swap<string>( ref firstDateStr,ref afterDateStr);
            }

            totalDrinksOrder.Text = BillBUS.Instance.GetCountProductBetweenDayAndDay(firstDateStr,afterDateStr).ToString();
            totalBill.Text = BillBUS.Instance.GetCountBillBetweenDayAndDay(firstDateStr, afterDateStr).ToString();
            totalSales.Text = BillBUS.Instance.GetTotalSaleBetweenDayAndDay(firstDateStr,afterDateStr).ToString();  
            dataGridView1.DataSource =BillBUS.Instance.GetInfoBillStatistics(firstDateStr,afterDateStr);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        
        void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b; 
            b = temp;
        }
    }
}
