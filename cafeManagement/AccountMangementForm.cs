using cafeManagement.Resource.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace cafeManagement
{
    public partial class AccountMangementForm : Form
    {
        List<string> stringStorage = new List<string>(); 

        public AccountMangementForm()
        {
            InitializeComponent();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dataGridView1.SelectedCells[0].Value.ToString());
            (new EditAccountForm()).Show();

        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            Form addNewAccount = new AddNewAccountForm();
            addNewAccount.Show();
        }

        private void deleteAccount_click(object s, EventArgs e)
        {
            if (DataProvider.Instance.ExecuteNonQueryToDelete(stringStorage) > 0)
            {
                MessageBox.Show("Xoá tài khoản thành công");
            }
            else
                MessageBox.Show("Xoá tài khoản không thành công");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                stringStorage.Clear();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    stringStorage.Add(row.Cells[i].Value.ToString());
                }
                Debug.WriteLine("clicked");
            }
        }

        private void onLoad(object sender, EventArgs e)
        {
            string query = "Select * from dbo.Account";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            Debug.WriteLine(stringStorage.Count);
        }

        private void onLoadDataBySearch(object sender, EventArgs e)
        {
            string query = "Select * from dbo.Account where UserName like  '%" + bunifuTextBox1.Text + "%'";
            try
            {
                dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}

