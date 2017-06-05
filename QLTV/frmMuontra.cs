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
    public partial class frmMuontra : Form
    {
        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");
        public frmMuontra()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtb_cmnd.Clear();
            txtb_masach.Clear();
            txtb_ten.Clear();
            txtb_tensach.Clear();
            txtb_tim.Clear();
            
        }
        //LOAD FORM.
        public void Muontra_hienthi()
        {
            Muontra muontra = new Muontra();
            dtMuontra.DataSource = muontra.Show();
            dtMuontra.Columns[0].HeaderText = "CMND";
            dtMuontra.Columns[1].HeaderText = "Họ và Tên";
            dtMuontra.Columns[2].HeaderText = "Ngày mượn";
            dtMuontra.Columns[3].HeaderText = "Mã Sách";
            dtMuontra.Columns[4].HeaderText = "Tên Sách";
            dtMuontra.Columns[5].HeaderText = "Hạn trả";
            dtMuontra.Show();
        }

        private void frmMuontra_Load(object sender, EventArgs e)
        {

        }

        //TÌM KIẾM BẰNG SỰ KIỆN TEXT CHANGED (THEO TÊN ĐỘC GIẢ, TÊN SÁCH)
        private void txtb_tim_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            if (cb_tim.Text == "Họ và Tên")
            {
                string tk = "select * from Muontra where tendocgia like '%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dtMuontra.DataSource = dta;
            }
            if (cb_tim.Text == "Tên sách")
            {
                string tk = "select * from Sach where tensach like N'%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dtMuontra.DataSource = dta;
            }
        }

        //THÊM THÔNG TIN MƯỢN TRẢ MỚI.
        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        //SỬA THÔNG TIN MƯỢN TRẢ ĐÃ CHỌN.
        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        //XÓA THÔNG TIN MƯỢN TRẢ ĐÃ CHỌN.
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dtMuontra.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn độc giả");
                return;
            }
            Muontra drview = (Muontra)dtMuontra.SelectedRows[0].DataBoundItem;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn trả này ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                drview.Xoa(drview.cmnd);
            else return;
            frmMuontra_Load(sender, e);
        }
          // Xóa thông tin có trong các textbox
        private void bntClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void dtMuontra_SelectionChanged(object sender, EventArgs e)
        {
            txtb_cmnd.Text = dtMuontra.CurrentRow.Cells[0].Value.ToString();
            txtb_ten.Text = dtMuontra.CurrentRow.Cells[1].Value.ToString();
            dtp_ngaymuon.Value = DateTime.Parse(dtMuontra.CurrentRow.Cells[2].Value.ToString());
            txtb_masach.Text = dtMuontra.CurrentRow.Cells[3].Value.ToString();
            txtb_tensach.Text = dtMuontra.CurrentRow.Cells[4].Value.ToString();
            dtp_hantra.Value = DateTime.Parse(dtMuontra.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
