using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Model
{
    class Muontra
    {
        SqlConnection con = new SqlConnection("server=HP6460B-PC\\SQLEXPRESS;database=QLTV;integrated security=SSPI");
    
        public string tendocgia { get; set; }
        public string cmnd { get; set; }
        public string tensach  { get; set; }
        public string masach { get; set; }
        public string ngaymuon { get; set; }
        public string ngaytra { get; set; }

        public List<Muontra> Show()
        {
            List<Muontra> lst = new List<Muontra>();
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xem_muontra", con);
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Muontra muontra = new Muontra();
                muontra.tendocgia = row[1].ToString();
                muontra.cmnd = row[2].ToString();
                muontra.tensach = row[3].ToString();
                muontra.masach = row[4].ToString();
                muontra.ngaymuon = row[5].ToString();
                muontra.ngaytra = row[6].ToString();
                lst.Add(muontra);
            }
            con.Close();
            return lst;
        }
        public void Xoa(string cmnd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("xoa_muontra", con);
            sc.Parameters.Add(new SqlParameter("cmnd", cmnd));
            sc.ExecuteNonQuery();
            con.Close();
        }

        public void Add(Muontra mt)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand sc = new SqlCommand("them_muontra", con);
            sc.Parameters.Add(new SqlParameter("ten", mt.tendocgia));
            sc.Parameters.Add(new SqlParameter("cmnd", mt.cmnd));
            sc.Parameters.Add(new SqlParameter("tensach", mt.tensach));
            sc.Parameters.Add(new SqlParameter("masach", mt.masach));
            sc.Parameters.Add(new SqlParameter("ngaymuon", mt.ngaymuon));
            sc.Parameters.Add(new SqlParameter("hantra", mt.ngaytra));
            sc.CommandType = CommandType.StoredProcedure;
            sc.ExecuteNonQuery();
            con.Close();
        }

    }
}
