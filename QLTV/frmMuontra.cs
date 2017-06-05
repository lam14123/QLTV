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
        Muontra mt = new Muontra();
        Sach sc = new Sach();
        Docgia dg = new Docgia();

        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");
        public frmMuontra()
        {
            InitializeComponent();
        }

        public void Muontra_hienthi()
        {
            datagridview1.DataSource = mt.Show();
            datagridview1.Columns[0].HeaderText = "Họ và Tên";
            datagridview1.Columns[1].HeaderText = "CMND";
            datagridview1.Columns[2].HeaderText = "Tên Sách";
            datagridview1.Columns[3].HeaderText = "Mã Sách";
            datagridview1.Columns[4].HeaderText = "Ngày mượn";
            datagridview1.Columns[5].HeaderText = "Hạn trả";
            datagridview1.Show();
            foreach(var item in sc.Show())
            {
                cb_masach.Items.Add(item.id);
            }
            foreach(var item in dg.Show())
            {
                cb_cmnd.Items.Add(item.cmnd);
            }
        }

        //ĐƯA DỮ LIỆU RA TEXTBOX KHI CLICK VÀO DATAGRIDVIEW.
        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_ten.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            cb_cmnd.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            txtb_tensach.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            cb_masach.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
            dtp_ngaymuon.Value = DateTime.Parse(datagridview1.CurrentRow.Cells[4].Value.ToString());
            dtp_hantra.Value = DateTime.Parse(datagridview1.CurrentRow.Cells[5].Value.ToString());
        }

        //LOAD FORM.
        private void frmMuontra_Load(object sender, EventArgs e)
        {
            Muontra_hienthi();
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
                datagridview1.DataSource = dta;
            }
            if (cb_tim.Text == "Tên sách")
            {
                string tk = "select * from Sach where tensach like N'%" + txtb_tim.Text.Trim() + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, con);
                DataTable dta = new DataTable();
                add.Fill(dta);
                datagridview1.DataSource = dta;
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
            if (datagridview1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn phiếu mượn trả!");
                return;
            }
            Muontra drview = (Muontra)datagridview1.SelectedRows[0].DataBoundItem;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn trả này ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                drview.Xoa(drview.cmnd);
            else return;
            frmMuontra_Load(sender, e);
        }

        //
        private void cb_cmnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in dg.Show())
            {
                if (item.cmnd == cb_cmnd.Text)
                {
                    txtb_ten.Text = item.ten;
                    break;
                }
            }
            foreach (var item in sc.Show())
            {
                if (item.id == cb_masach.Text)
                {
                    txtb_tensach.Text = item.ten;
                    break;
                }
            }
        }
    }
}
