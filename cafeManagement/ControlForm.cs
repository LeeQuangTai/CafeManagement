using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{

    public partial class ControlForm : ViewForm
    {
    
        private Form childFormCheck = null;
        public bool isSignOut = true ;
        private Form displayForm = new Form();
        public override FormType FormType => FormType.Control; 
        public ControlForm()
        {
            InitializeComponent();
        }
        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

      

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            displayForm = AddChildFormToPanel(new OrderForm());
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {

            displayForm = AddChildFormToPanel(new OverviewForm());
        }


  

        public Form AddChildFormToPanel(Form childForm)
        {
            if (childFormCheck != null)
            {
                childFormCheck.Close();
            }
            if (childForm == null)
                return null;
            childFormCheck = childForm;
            childForm.TopLevel = false;
            childForm.Parent = this.displayFormPanel;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            displayForm = AddChildFormToPanel(new MenuForm());
        }

        private void signOut_click(object sender, EventArgs e)
        {
            isSignOut = true;
            Program.SwitchFormType(FormType.Login);
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            displayForm = AddChildFormToPanel(new AccountMangementForm());
        }
        public override void OnShow()
        {
            base.OnShow();
            AddChildFormToPanel(null);
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                if (displayForm != null)
                {
                    displayForm.Close();
                }
                e.Cancel = true;
            }
        }
                

    }
}   