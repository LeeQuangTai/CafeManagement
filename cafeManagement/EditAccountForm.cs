using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafeManagement.Resource.DAO;
namespace cafeManagement
{
    public partial class EditAccountForm : Form
    {
        public EditAccountForm()
        {
            InitializeComponent();
        }

        

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "" || bunifuTextBox4.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống!");
                }
                else
                {
                    if (DataProvider.Instance.ExecuteNonQueryToEdit(comboBox2.Text, bunifuTextBox4.Text, bunifuTextBox3.Text, bunifuTextBox2.Text, (comboBox1.Text == "Admin" ? 1 : 2).ToString()) > 0 ? true : false)
                        MessageBox.Show("Chỉnh sửa hành công!");
                    else
                        MessageBox.Show("Chỉnh sứa thất bại!");
                }
            }
        }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeManagementDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.cafeManagementDataSet.Account);
        }
    }
}
