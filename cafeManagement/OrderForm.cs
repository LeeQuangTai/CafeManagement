using cafeManagement.Resource.DAO;
using cafeManagement.Resource.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            TableLoad();
            LoadDrinkCategory();
        }
        #region method
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
            textBox1.Text = totalPrice.ToString("c", culture);
        }


        #endregion

        #region events

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Table).TableID;
            dgvOrder.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            lbTable.Text = ((sender as Button).Tag as Table).TableName;
            //CultureInfo culture = new CultureInfo("vi-VN");
            //textBox1.Text = thanhTien.ToString("c", culture);

        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            Table table = dgvOrder.Tag as Table;
            int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
            string drinkID = (cbbDrink.SelectedItem as Drink).DrinkID;
            int quantity = (int)nudQuantity.Value;
            if (billID == -1)
            {
                BillDAO.Instance.InsertBill(table.TableID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), drinkID, quantity);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(billID, drinkID, quantity);
            }
            ShowBill(table.TableID);
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

            if (billID != -1)
            {
                if (MessageBox.Show("Thanh toán hóa đơn " + table.TableName + "?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(billID);
                    ShowBill(table.TableID);
                    TableLoad();
                }
            }
        }



        #endregion


    }
}
