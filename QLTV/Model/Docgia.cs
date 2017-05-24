using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Model
{
    class Docgia
    {
<<<<<<< HEAD
        //SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");
        SqlConnection con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=QLTV;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=SUPER\SQLEXPRESS ;Initial Catalog=TTN_Quanlythuvien ;Persist Security Info=True; User ID=detai6 ;Password=detai6 ");
=======
        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");

>>>>>>> parent of 1e8fe68... dong
        public string cmnd { get; set; }
        public string ten { get; set; }
        public string ngaysinh { get; set; }
        public string diachi { get; set; }
        public string gioitinh { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }

        public List<Docgia> Show()
        {
            List<Docgia> lst = new List<Docgia>();
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xem_docgia", con);
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Docgia Docgia = new Docgia();
                Docgia.cmnd = row[0].ToString();
                Docgia.ten = row[1].ToString();
                Docgia.ngaysinh = row[2].ToString();
                Docgia.diachi = row[3].ToString();
                Docgia.gioitinh = row[4].ToString();
                Docgia.taikhoan = row[5].ToString();
                Docgia.matkhau = row[6].ToString();
                lst.Add(Docgia);
            }
            con.Close();
            return lst;
        }

        public void Add(Docgia docgia)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("them_docgia", con);
            sc.Parameters.Add(new SqlParameter("cmnd", docgia.cmnd));
            sc.Parameters.Add(new SqlParameter("ten", docgia.ten));
            sc.Parameters.Add(new SqlParameter("ngaysinh", docgia.ngaysinh));
            sc.Parameters.Add(new SqlParameter("diachi", docgia.diachi));
            sc.Parameters.Add(new SqlParameter("gioitinh", docgia.gioitinh));
            sc.Parameters.Add(new SqlParameter("taikhoan", docgia.taikhoan));
            sc.Parameters.Add(new SqlParameter("matkhau", docgia.matkhau));
            sc.CommandType = CommandType.StoredProcedure;
            sc.ExecuteNonQuery();
            con.Close();
        }

        public void Xoa(string cmnd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xoa_docgia", con);
            sc.Parameters.Add(new SqlParameter("id", cmnd));
            sc.ExecuteNonQuery();
            con.Close();
        }

        public void Sua(Docgia docgia, string current_cmnd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("sua_docgia", con);
            sc.Parameters.Add(new SqlParameter("s", current_cmnd));
            sc.Parameters.Add(new SqlParameter("cmnd", docgia.cmnd));
            sc.Parameters.Add(new SqlParameter("ten", docgia.ten));
            sc.Parameters.Add(new SqlParameter("ngaysinh", docgia.ngaysinh));
            sc.Parameters.Add(new SqlParameter("diachi", docgia.diachi));
            sc.Parameters.Add(new SqlParameter("gioitinh", docgia.gioitinh));
            sc.Parameters.Add(new SqlParameter("taikhoan", docgia.taikhoan));
            sc.Parameters.Add(new SqlParameter("matkhau", docgia.matkhau));
            sc.CommandType = CommandType.StoredProcedure;
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}

