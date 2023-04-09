using cafeManagement.BUS;
using cafeManagement.DTO;
using cafeManagement.Resource.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace cafeManagement
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            OrderBUS.Instance.TableLoad(fLPTable, btn_Click);
            OrderBUS.Instance.LoadDrinkCategory(cbbCategory);
            OrderBUS.Instance.LoadTableTransfer(cbbTransfer);
        }

        #region events

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }
        private void btn_Click(object sender, EventArgs e)
        {
            nudDiscount.Value = 0;
            txtPayment.Text = null;
            string tableID = ((sender as Button).Tag as DTO.Table).TableID;
            dgvOrder.Tag = (sender as Button).Tag;
            OrderBUS.Instance.ShowBill(dgvOrder, txtTotalPrice, tableID);
            lbTable.Text = ((sender as Button).Tag as DTO.Table).TableName;

        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
           
                txtPayment.Text = null;
                OrderBUS.Instance.AddDrink(dgvOrder, cbbDrink, nudQuantity, txtTotalPrice);
                OrderBUS.Instance.TableLoad(fLPTable, btn_Click);
            
        }
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {           
            OrderBUS.Instance.GetListDrink(cbbCategory, cbbDrink);       
        }
        private void btnPay_Click(object sender, EventArgs e)
        {

            OrderBUS.Instance.Pay(dgvOrder, nudDiscount, txtPayment, fLPTable, btn_Click);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

            try
            {
                int discount = (int)nudDiscount.Value;
                double totalPrice = (double)double.Parse(txtTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
                double payment = (totalPrice - (totalPrice / 100) * discount);
                CultureInfo culture = new CultureInfo("vi-VN");
                txtPayment.Text = payment.ToString("c", culture);
            }
            catch (FormatException)
            {

                MessageBox.Show("Mời chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {

            OrderBUS.Instance.TableTransfer(dgvOrder, cbbTransfer, nudDiscount, txtTotalPrice, fLPTable, btn_Click);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderBUS.Instance.DeleteOrder(dgvOrder, txtTotalPrice, fLPTable, btn_Click);
        }

        #endregion

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dgvOrder.Rows[e.RowIndex];
            //cbbDrink.DisplayMember = Convert.ToString(row.Cells["DrinkName"].Value);
            //nudQuantity.Value = int.Parse(Convert.ToString(row.Cells["Quantity"].Value));
        }
    }
}
