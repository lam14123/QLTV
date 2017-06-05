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
        SqlConnection con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=QLTV;Integrated Security=True");
       // SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");

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
            if (con.State != ConnectionState.Open)
                con.Open();

            if (cb_tim.Text == "Mã sách")
            {
                string tk = "select * from Sach where id like '%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dataGridView1.DataSource = dta;
            }
            if (cb_tim.Text == "Tên sách")
            {
                string tk = "select * from Sach where ten like N'%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dataGridView1.DataSource = dta;
            }
            if (cb_tim.Text == "Tác Giả")
            {
                string tk = "select * from Sach where tacgia like N'%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dataGridView1.DataSource = dta;
            }
            con.Close();
        }

        //THÊM ĐẦU SÁCH MỚI.
        private void btn_them_Click(object sender, EventArgs e)
        {
            Sach sc = new Sach();
            foreach(var item in sc.Show())
            {
                if (txtb_id.Text == "" || txtb_id.Text == item.id)
                {
                    MessageBox.Show("Sai mã!");
                }
                else
                {
                    sc.id = txtb_id.Text;
                }
            }
            
            sc.ten = txtb_ten.Text;
            if (txtb_soluong.Text != "")
                sc.soluong = int.Parse(txtb_soluong.Text);
            else
                sc.soluong = 0;
            sc.tacgia = txtb_tacgia.Text;
            sc.theloai = txtb_theloai.Text;
            sc.nxb = txtb_nxb.Text;
            sc.Add(sc);
            MessageBox.Show("Thêm mới thành công!");
            frmSach_Load(sender, e);
        }

        //CẬP NHẬT LẠI THÔNG TIN ĐẦU SÁCH ĐÃ CHỌN.
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string curr_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Sach sc = new Sach();
            sc.id = txtb_id.Text;
            sc.ten = txtb_ten.Text;
            if (txtb_soluong.Text != "")
                sc.soluong = int.Parse(txtb_soluong.Text);
            else
                sc.soluong = 0;
            sc.tacgia = txtb_tacgia.Text;
            sc.theloai = txtb_theloai.Text;
            sc.nxb = txtb_nxb.Text;
            sc.Sua(sc, curr_id);
            MessageBox.Show("Cập nhật thành công!");
            frmSach_Load(sender, e);
        }

        //XÓA ĐẦU SÁCH ĐÃ CHỌN.
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn đầu sách!");
                return;
            }
            Sach drview = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa đầu sách này ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                drview.Xoa(drview.id);
            else return;
            frmSach_Load(sender, e);
        }
    }
}
