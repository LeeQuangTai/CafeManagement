using cafeManagement.DTO;
using cafeManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace cafeManagement.BUS
{
    public class OrderBUS
    {
       private static OrderBUS instance;
        public static OrderBUS Instance
        {
            get { if (instance == null) instance = new OrderBUS(); return OrderBUS.instance; }
            private set { OrderBUS.instance = value; }
        }
        private OrderBUS() { }
        public void TableLoad(FlowLayoutPanel fLPanelTable, EventHandler btn_Click)
        {
            fLPanelTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TableName + Environment.NewLine + item.Status;
                //btn.Image = Image.FromFile(@"\table.png");
                //btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.Font = new Font("Times New Roman", 11) ;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(60, 42, 33);
                        btn.ForeColor = Color.FromArgb(255, 253, 195);
                        break;
                    case "Tr?ng":
                        btn.BackColor = Color.FromArgb(60, 42, 33);
                        btn.ForeColor = Color.FromArgb(255, 253, 195);
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }
                fLPanelTable.Controls.Add(btn);
            }

        }
        public void LoadTableTransfer(ComboBox cbb)
        {
            cbb.DataSource = TableDAO.Instance.LoadTableList();
            cbb.DisplayMember = "TableName";
        }
        public void LoadDrinkCategory(ComboBox cbb)
        {
            List<DrinkCategory> drinkCategories = DrinkCategoryDAO.Instance.GetDrinkCategories();
            cbb.DataSource = drinkCategories;
            cbb.DisplayMember = "DrinkCategoryName";
        }
       public void LoadListDrinkByDrinkCategoryID(ComboBox cbb, string drinkCategoryID)
        {
            List<Drink> drinks = DrinkDAO.Instance.GetListDrinkByCategoryID(drinkCategoryID);
            cbb.DataSource = drinks;
            cbb.DisplayMember = "DrinkName";
        }
        public void ShowBill(DataGridView dgv, TextBox txb, string tableID)
        {
            dgv.DataSource = null;
            float totalPrice = 0;
            List<Order> orders = OrderDAO.Instance.GetListOrderByTable(tableID);
            foreach (Order order in orders)
            {

                totalPrice += order.TotalPrice;
            }
            dgv.DataSource = orders;
            CultureInfo culture = new CultureInfo("vi-VN");
            txb.Text = totalPrice.ToString("c", culture);
        }
        public void AddDrink(DataGridView dgv, ComboBox cbb, NumericUpDown nud, TextBox txb)
        {
            try
            {
                Table table = dgv.Tag as Table;
                int? billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
                string drinkID = (cbb.SelectedItem as Drink).DrinkID;
                int quantity = (int)nud.Value;
                if (billID == -1)
                {
                    if ((int)nud.Value == 0 || (int)nud.Value <= 0)
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
                    if ((int)nud.Value == 0)
                    {
                        MessageBox.Show("Mời chọn lại số lượng!", "Thông báo");
                    }
                    else
                    {
                        BillInfoDAO.Instance.InsertBillInfo(billID, drinkID, quantity);
                    }
                }
                OrderBUS.Instance.ShowBill(dgv, txb, table.TableID);
                nud.Value = 0;
            }
            catch (NullReferenceException e)
            {

                MessageBox.Show("Mời chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void GetListDrink(ComboBox cbb, ComboBox cb)
        {
            string drinkCategoryID = "";
            if (cbb.SelectedItem == null)
                return;
            DrinkCategory drinkCategory = cbb.SelectedItem as DrinkCategory;
            drinkCategoryID = drinkCategory.DrinkCategoryID;

            OrderBUS.Instance.LoadListDrinkByDrinkCategoryID(cb, drinkCategoryID);
        }
        public void Pay(DataGridView dgv, NumericUpDown nud, TextBox txb, FlowLayoutPanel fLPanelTable, EventHandler btn_Click)
        {
            try
            {
                Table table = dgv.Tag as Table;
                int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
                int discount = (int)nud.Value;
                if (billID != -1)
                {
                    if (MessageBox.Show("Thanh toán hóa đơn " + table.TableName + "?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(billID, discount);
                        OrderBUS.Instance.ShowBill(dgv, txb, table.TableID);
                        OrderBUS.Instance.TableLoad(fLPanelTable, btn_Click);
                        txb.Text = null;
                    }
                }
                else
                    MessageBox.Show("Bàn được chọn chưa có hóa đơn chưa thanh toán!", "Thông báo");
                nud.Value = 0;
            }
            catch (NullReferenceException e)
            {

                MessageBox.Show("Mời chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteOrder(DataGridView dgv, TextBox txb, FlowLayoutPanel fLPanelTable, EventHandler btn_Click)
        {
            try
            {
                string tableID = (dgv.Tag as Table).TableID;
                Table table = dgv.Tag as Table;
                int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
                OrderDAO.Instance.DeleteOrder(tableID, billID);
                OrderBUS.Instance.ShowBill(dgv, txb, tableID);
                OrderBUS.Instance.TableLoad(fLPanelTable, btn_Click);
            }
            catch (NullReferenceException e)
            {

                MessageBox.Show("Mời chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void DatTrangThaiBan()
        //{
        //}
        public void TableTransfer(DataGridView dgv, ComboBox cbb, NumericUpDown nud, TextBox txb, FlowLayoutPanel fLPanelTable, EventHandler btn_Click, String lb)
        {
            try
            {
                string tableID1 = (dgv.Tag as Table).TableID;
                string tableID2 = (cbb.SelectedItem as Table).TableID;
                if ((dgv.Tag as Table).Status == "Trống")
                {
                    MessageBox.Show("Đây là bàn trống, bạn phải chọn bàn đã có người!", "Thông báo");
                    if (tableID1 == tableID2)
                    {
                        MessageBox.Show("Mời chọn bàn chuyển khác bàn được chuyển!", "Thông báo");
                    }
                }
                else
                {
                    if (tableID1 == tableID2)
                    {
                        MessageBox.Show("Mời chọn bàn chuyển khác bàn được chuyển!", "Thông báo");
                    }
                    else
                    {
                        if (MessageBox.Show(string.Format("Chuyển bàn {0} qua bàn {1}?", (dgv.Tag as Table).TableName, (cbb.SelectedItem as Table).TableName), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            TableDAO.Instance.TransferTable(tableID1, tableID2);
                            Table table = dgv.Tag as Table;
                            int billID = BillDAO.Instance.GetBillIDuncheck(table.TableID);
                            int discount = (int)nud.Value;
                            if (billID != -1)
                            {

                                BillDAO.Instance.CheckOut(billID, discount);
                                OrderBUS.Instance.ShowBill(dgv, txb, table.TableID);
                                OrderBUS.Instance.TableLoad(fLPanelTable, btn_Click);

                            }
                            OrderBUS.Instance.TableLoad(fLPanelTable, btn_Click);

                        }
                    }
                }
            }



            catch (NullReferenceException e)
            {

                MessageBox.Show("Mời chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

    
}


