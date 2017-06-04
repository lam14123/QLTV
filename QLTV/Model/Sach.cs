using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Model
{
    class Sach
    {
        //SqlConnection con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=QLTV;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=SUPER\SQLEXPRESS ;Initial Catalog=TTN_Quanlythuvien ;Persist Security Info=True; User ID=detai6 ;Password=detai6 ");

        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");
        public string id { get; set; }
        public string ten { get; set; }
        public int soluong { get; set; }
        public string tacgia { get; set; }
        public string theloai { get; set; }
        public string nxb { get; set; }

        public List<Sach> Show()
        {
            List<Sach> lst = new List<Sach>();
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xem_sach", con);
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                Sach sach = new Sach();
                sach.id = row[0].ToString();
                sach.ten = row[1].ToString();
                if (row[2].ToString() != null)
                    sach.soluong = int.Parse(row[2].ToString());
                else
                    sach.soluong = 0;
                sach.tacgia = row[3].ToString();
                sach.theloai = row[4].ToString();
                sach.nxb = row[5].ToString();
                lst.Add(sach);
            }
            con.Close();
            return lst;
        }

        public void Add(Sach sach)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("them_sach", con);
            sc.Parameters.Add(new SqlParameter("id", sach.id));
            sc.Parameters.Add(new SqlParameter("ten", sach.ten));
            sc.Parameters.Add(new SqlParameter("soluong", sach.soluong));
            sc.Parameters.Add(new SqlParameter("tacgia", sach.tacgia));
            sc.Parameters.Add(new SqlParameter("theloai", sach.theloai));
            sc.Parameters.Add(new SqlParameter("nxb", sach.nxb));
            sc.CommandType = CommandType.StoredProcedure;
            sc.ExecuteNonQuery();
            con.Close();
        }

        public void Xoa(string id)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xoa_sach", con);
            sc.Parameters.Add(new SqlParameter("id", id));
            sc.ExecuteNonQuery();
            con.Close();
        }

        public void Sua(Sach sach, string current_id)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("sua_sach", con);
            sc.Parameters.Add(new SqlParameter("s", current_id));
            sc.Parameters.Add(new SqlParameter("id", sach.id));
            sc.Parameters.Add(new SqlParameter("ten", sach.ten));
            sc.Parameters.Add(new SqlParameter("soluong", sach.soluong));
            sc.Parameters.Add(new SqlParameter("tacgia", sach.tacgia));
            sc.Parameters.Add(new SqlParameter("theloai", sach.theloai));
            sc.Parameters.Add(new SqlParameter("nxb", sach.nxb));
            sc.CommandType = CommandType.StoredProcedure;
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
