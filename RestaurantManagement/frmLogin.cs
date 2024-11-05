using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmLogin : Form
    {
        private String mUsername;
        private String mPassword;
        public frmLogin()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                           "Xác nhận thoát",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mUsername = txtUsername.Text;
            mPassword = txtPassword.Text;

            bool result = true;

            if (result)
            {
                frmTableManager frmTableManager = new frmTableManager();
                this.Hide();
                frmTableManager.ShowDialog();
                this.Show();
            }
        }
    }
}
