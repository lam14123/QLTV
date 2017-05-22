using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (!txtb_tk.Text.Equals("admin"))
            {
                err_tk.SetError(txtb_tk, "Sai tài khoản!");
                if (!txtb_mk.Text.Equals("123"))
                {
                    err_mk.SetError(txtb_mk, "Sai mật khẩu!");
                }
            }
            else
            {
                err_tk.Clear();
                err_mk.Clear();
                this.Hide();
                (new frmMain()).ShowDialog();
                this.Close();
            }
                
        }
    }
}
