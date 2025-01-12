using System;
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
    public partial class frmAccountProfile : Form
    {
        public frmAccountProfile()
        {
            InitializeComponent();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            bool result = txtPassword.UseSystemPasswordChar;
            if (result)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnViewNewPass_Click(object sender, EventArgs e)
        {
            bool result = txtNewPass.UseSystemPasswordChar;
            if (result)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void btnViewConfirmPass_Click(object sender, EventArgs e)
        {
            bool result = txtConfirmPass.UseSystemPasswordChar;
            if (result)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
