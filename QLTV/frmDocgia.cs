using QLTV.Model;
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
    public partial class frmDocgia : Form
    {
        public frmDocgia()
        {
            InitializeComponent();
        }
        //HIỂN THỊ DỮ LIỆU LÊN DATAGRIDVIEW.
        public void Docgia_hienthi()
        {
            Docgia docgia = new Docgia();
            dataGridView1.DataSource = docgia.Show();
            dataGridView1.Show();
        }

        //LOAD FORM.
        private void frmDocgia_Load(object sender, EventArgs e)
        {
            Docgia_hienthi();
        }

        //TÌM KIẾM BẰNG SỰ KIỆN TEXT CHANGED (THEO CMND, TÊN ĐỘC GIẢ)
        private void txtb_tim_TextChanged(object sender, EventArgs e)
        {

        }

        //THÊM ĐỘC GIẢ MỚI.
        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        //CẬP NHẬT THÔNG TIN ĐỘC GIẢ ĐÃ CHỌN.
        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        //XÓA ĐỘC GIẢ ĐA CHỌN.
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn độc giả");
                return;
            }
            Docgia drview = (Docgia)dataGridView1.SelectedRows[0].DataBoundItem;
            int kt = drview.Xoa(drview.cmnd);
            if (kt == 1)
            {

                MessageBox.Show("Xóa thành công !");
                frmDocgia_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi thực thi !");
            }
        }
    }
}
