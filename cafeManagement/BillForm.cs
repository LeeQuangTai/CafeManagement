using cafeManagement.DAO;
using cafeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            ViewBill();
        }
        void ViewBill()
        {
            List<ViewBill> viewBills = BillDAO.Instance.GetListViewBill();
            dataGridView1.DataSource = viewBills;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
