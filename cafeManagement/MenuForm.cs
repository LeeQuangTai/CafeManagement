using System.Windows.Forms;

namespace cafeManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Add(11, "Trà sữa trân châu", "Đồ uống", 20000);
            dataGridView1.Rows.Add(12, "Trà sữa Khoai môn", "Đồ uống", 20000);
            dataGridView1.Rows.Add(13, "Trà sữa việt quất", "Đồ uống", 20000);
            dataGridView1.Rows.Add(14, "Cà phê đá", "Đồ uống", 15000);
            dataGridView1.Rows.Add(15, "Cà phê sữa", "Đồ uống", 17000);
            dataGridView1.Rows.Add(21, "Bánh tráng trộn", "Thức ăn", 10000);
            dataGridView1.Rows.Add(22, "Cá viên chiên", "Thức ăn", 15000);
            dataGridView1.Rows.Add(23, "Trà sữa trân châu", "Đồ uống", 20000);



        }

        private void bunifuTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, System.EventArgs e)
        {

        }
    }
}