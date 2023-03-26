﻿using cafeManagement.Resource.BUS;
using cafeManagement.Resource.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class DeleteAccountForm : Form
    {
        public DeleteAccountForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            var data = DataProvider.Instance.ExecuteQuery("select userName from dbo.account");
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account();
                acc.UserName = item[0].ToString();
                comboBox2.Items.Add(acc.UserName);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (AccountBUS.Instance.DeleteAccount(comboBox2.Text) > 0)
            {
                MessageBox.Show("Xoá tài khoản thành công");
            }
            else
                MessageBox.Show("Xoá tài khoản không thành công");
        }
    }
}