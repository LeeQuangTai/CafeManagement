using cafeManagement.BUS;
//using cafeManagement.DAO;
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
            BillBUS.Instance.LoadListBIllID(cbMaHD, dateXuatHoaDon.Value.ToString("MM/dd/yyyy"));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            string dateCheckIn = dateXuatHoaDon.Value.ToString("MM/dd/yyyy");
            int billID = Convert.ToInt32(cbMaHD.Text);
            BillBUS.Instance.LoadListViewBill(txtTongTien, dgvHoaDon, billID, dateCheckIn);
        }

        private void dateXuatHoaDon_ValueChanged(object sender, EventArgs e)
        {
            BillBUS.Instance.LoadListBIllID(cbMaHD, dateXuatHoaDon.Value.ToString("MM/dd/yyyy"));
        }
    }
}
