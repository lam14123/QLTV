using QLTV.Model;
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

namespace QLTV
{
   
    public partial class frmDocgia : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=QLTV;Integrated Security=True");
        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");

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

        //ĐƯA DỮ LIỆU RA TEXTBOX KHI CLICK VÀO DATAGRIDVIEW.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_cmnd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtb_ten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() != "")
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            rtxtb_diachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nam")
                rbtn_nam.Checked = true;
            else
                rbtn_nu.Checked = true;
            txtb_taikhoan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtb_matkhau.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        //TÌM KIẾM BẰNG SỰ KIỆN TEXT CHANGED (THEO CMND, TÊN ĐỘC GIẢ)
        private void txtb_tim_TextChanged(object sender, EventArgs e)
        {
            if (cb_tim.Text== "CMND")
            {
                con.Open();
                string tk = "select * from Docgia where cmnd like '%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dataGridView1.DataSource = dta;
                con.Close();
            }
            if (cb_tim.Text == "Họ và Tên")
            {
                con.Open();
                string tk = "select * from Docgia where ten like N'%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dataGridView1.DataSource = dta;
                con.Close();
            }


        }

        //THÊM ĐỘC GIẢ MỚI.
        private void btn_them_Click(object sender, EventArgs e)
        {
            Docgia dg = new Docgia();
            foreach (var item in dg.Show())
            {
                if (txtb_cmnd.Text == "" || txtb_cmnd.Text == item.cmnd)
                {
                    MessageBox.Show("Sai cmnd!");
                }
                else
                {
                    dg.cmnd = txtb_cmnd.Text;
                }
            }
            
            dg.ten = txtb_ten.Text;
            dg.ngaysinh = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            dg.diachi = rtxtb_diachi.Text;
            if (rbtn_nam.Checked == true)
                dg.gioitinh = "Nam";
            else
                dg.gioitinh = "Nữ";
            dg.taikhoan = txtb_taikhoan.Text;
            dg.matkhau = txtb_matkhau.Text;
            dg.Add(dg);
            MessageBox.Show("Thêm mới thành công!");
            frmDocgia_Load(sender, e);
        }

        //CẬP NHẬT THÔNG TIN ĐỘC GIẢ ĐÃ CHỌN.
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string curr_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Docgia dg = new Docgia();
            dg.cmnd = txtb_cmnd.Text;
            dg.ten = txtb_ten.Text;
            dg.ngaysinh = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            dg.diachi = rtxtb_diachi.Text;
            if (rbtn_nam.Checked == true)
                dg.gioitinh = "Nam";
            else
                dg.gioitinh = "Nữ";
            dg.taikhoan = txtb_taikhoan.Text;
            dg.matkhau = txtb_matkhau.Text;
            dg.Sua(dg, curr_id);
            MessageBox.Show("Cập nhật thành công!");
            frmDocgia_Load(sender, e);
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
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa độc giả này ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                drview.Xoa(drview.cmnd);
            else return;
            frmDocgia_Load(sender, e);

            
        }
    }
}
