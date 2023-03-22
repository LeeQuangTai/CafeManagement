using cafeManagement.Resource.DAO;
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
            TableLoad();
            LoadDrinkCategory();
            LoadTableTransfer(cbbTransfer);
        }
        #region method
        void LoadTableTransfer(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "TableName";
        }
        void LoadDrinkCategory()
        {
            List<DrinkCategory> drinkCategories = DrinkCategoryDAO.Instance.GetDrinkCategories();
            cbbCategory.DataSource = drinkCategories;
            cbbCategory.DisplayMember = "DrinkCategoryName";
        }
        void LoadListDrinkByDrinkCategoryID(string drinkCategoryID)
        {
            List<Drink> drinks = DrinkDAO.Instance.GetListDrinkByCategoryID(drinkCategoryID);
            cbbDrink.DataSource = drinks;
            cbbDrink.DisplayMember = "DrinkName";
        }
        void TableLoad()
        {
            fLPTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TableName + Environment.NewLine + item.Status;
                //btn.Image = Image.FromFile(@"\table.png");
                //btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    case "Tr?ng":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Gray;
                        break;
                }

                fLPTable.Controls.Add(btn);
            }
        }



        void ShowBill(string tableID)
        {
            //List<BillInfo> billInfos = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillIDuncheck(tableID));
            //dgvOrder.DataSource = billInfos;
            dgvOrder.DataSource = null;
            float totalPrice = 0;
            List<Order> orders = OrderDAO.Instance.GetListOrderByTable(tableID);
            foreach (Order order in orders)
            {

                totalPrice += order.TotalPrice;
            }
            dgvOrder.DataSource = orders;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }


        #endregion

        #region events

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }
        private void btn_Click(object sender, EventArgs e)
        {
            nudDiscount.Value = 0;
            txtPayment.Text = null;
            string tableID = ((sender as Button).Tag as Table).TableID;
            dgvOrder.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            //if(dgvOrder.DataSource == null)
            //{
            //    Table table = TableDAO.Instance.LoadTableNotBill(tableID);
            //    Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
            //    btn.Text = table.TableName + Environment.NewLine + table.Status;

            //}
            lbTable.Text = ((sender as Button).Tag as Table).TableName;

        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            txtPayment.Text = null;
            Table table = dgvOrder.Tag as Table;
            int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
            string drinkID = (cbbDrink.SelectedItem as Drink).DrinkID;
            int quantity = (int)nudQuantity.Value;
            if (billID == -1)
            {
                if ((int)nudQuantity.Value == 0)
                {
                    MessageBox.Show("Mời chọn lại số lượng!", "Thông báo");
                }
                else
                {
                    BillDAO.Instance.InsertBill(table.TableID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), drinkID, quantity); 
                }
                
            }
            else
            {
                if ((int)nudQuantity.Value == 0)
                {
                    MessageBox.Show("Mời chọn lại số lượng!", "Thông báo");
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(billID, drinkID, quantity);
                }
            }
            ShowBill(table.TableID);
            nudQuantity.Value = 0;
            TableLoad();

        }
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drinkCategoryID = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DrinkCategory drinkCategory = cb.SelectedItem as DrinkCategory;
            drinkCategoryID = drinkCategory.DrinkCategoryID;

            LoadListDrinkByDrinkCategoryID(drinkCategoryID);
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = dgvOrder.Tag as Table;          
            int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
            int discount = (int)nudDiscount.Value;
            if (billID != -1)
            {
                if (MessageBox.Show("Thanh toán hóa đơn " + table.TableName + "?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(billID, discount);
                    ShowBill(table.TableID);
                    TableLoad();
                    txtPayment.Text = null;
                }
            }
            nudDiscount.Value = 0;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                int discount = (int)nudDiscount.Value;
                double totalPrice = double.Parse(txtTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
                double payment = (totalPrice - (totalPrice / 100) * discount);
                CultureInfo culture = new CultureInfo("vi-VN");
                txtPayment.Text = payment.ToString("c", culture);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string tableID1 = (dgvOrder.Tag as Table).TableID;
            string tableID2 = (cbbTransfer.SelectedItem as Table).TableID;
            if ((dgvOrder.Tag as Table).Status == "Trống")
            {
                MessageBox.Show("Xin vui lòng chọn bàn có người!", "Thông báo");          
                if (tableID1== tableID2)
                {
                    MessageBox.Show("Mời chọn bàn chuyển khác bàn được chuyển!", "Thông báo");
                }
            }
            else
            {

                //if (((sender as Button).Tag as Table).Status == "Trống")
                //{
                //    MessageBox.Show("Đây là bàn trống, bạn phải chọn bàn đã có người!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                if (MessageBox.Show(string.Format("Chuyển bàn {0} qua bàn {1}?", (dgvOrder.Tag as Table).TableName, (cbbTransfer.SelectedItem as Table).TableName), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.TransferTable(tableID1, tableID2);
                    Table table = dgvOrder.Tag as Table;
                    int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
                    int discount = (int)nudDiscount.Value;
                    if (billID != -1)
                    {
                        
                            BillDAO.Instance.CheckOut(billID, discount);
                            ShowBill(table.TableID);
                            TableLoad();
                            
                    }
                    TableLoad();

                }
                
            }
        }






        #endregion


    }
}
