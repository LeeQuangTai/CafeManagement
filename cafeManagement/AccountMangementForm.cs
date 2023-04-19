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
using System.Security.Cryptography;
using System.Reflection;
using cafeManagement.BUS;
namespace cafeManagement
{
    public partial class AccountMangementForm : Form
    {
        List<string> stringStorage = new List<string>();
        public AccountMangementForm()
        {
            InitializeComponent();
            onLoad();
        }
        void onLoad()
        {
            AccountBUS.Instance.LoadAllAccount(dataGridView1);
        }
        private void onLoad_Click(object sender, EventArgs e)
        {
            onLoad();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form editAccountForm = new EditAccountForm(); 
            editAccountForm.ShowDialog();
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            Form addNewAccount = new AddNewAccountForm();
            addNewAccount.ShowDialog();
        }

        private void deleteAccount_click(object s, EventArgs e)
        {
            Form deleteAccount = new DeleteAccountForm();
            deleteAccount.ShowDialog();
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
            }
        }

      
        private void onLoadDataBySearch_click(object sender, EventArgs e)
        {
            BUS.AccountBUS.Instance.LoadAccountBySearch(dataGridView1, bunifuTextBox1.Text);
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                BUS.AccountBUS.Instance.LoadAccountBySearch(dataGridView1, bunifuTextBox1.Text);
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

