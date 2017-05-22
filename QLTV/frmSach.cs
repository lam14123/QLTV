using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Model;

namespace QLTV
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        //HIỂN THỊ DỮ LIỆU LÊN DATAGRIDVIEW.
        public void Sach_hienthi()
        {
            Sach sach = new Sach();
            dataGridView1.DataSource = sach.Show();
            dataGridView1.Columns[0].HeaderText = "Mã Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Sách";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Tác Giả";
            dataGridView1.Columns[4].HeaderText = "Thể Loại";
            dataGridView1.Columns[5].HeaderText = "Nhà Xuất Bản";
            dataGridView1.Show();
        }

        //LOAD FORM.
        private void frmSach_Load(object sender, EventArgs e)
        {
            Sach_hienthi();
        }

        //ĐƯA DỮ LIỆU RA TEXTBOX KHI CLICK VÀO DATAGRIDVIEW.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtb_ten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtb_soluong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtb_tacgia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtb_theloai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtb_nxb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        //TÌM KIẾM BẰNG SỰ KIỆN TEXTCHANGED (THEO MÃ SÁCH, TÊN SÁCH, TÁC GIẢ).
        private void txtb_tim_TextChanged(object sender, EventArgs e)
        {

        }

        //THÊM ĐẦU SÁCH MỚI.
        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        //CẬP NHẬT LẠI THÔNG TIN ĐẦU SÁCH ĐÃ CHỌN.
        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        //XÓA ĐẦU SÁCH ĐÃ CHỌN.
        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
