using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GK
{
    public class QLBHADO
    {
        string connectString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectString);
            da.Fill(dt);
            return dt;
        }
        public bool checkMaKH(string maKH)
        {
            string sql = @"select count (*) from KHACHHANG where MAKH=@makh";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makh", maKH);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return (count >= 1);
        }
        public bool insertKH(KHang kh)
        {
            string sql = @"insert into KHACHHANG values (@makh, @tenkh, @sdt)";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tenkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool updateKH (KHang kh)
        {
            string sql = @"update KHACHHANG set HOTEN=@tenkh, SDT=@sdt where MAKH=@makh";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@makh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tenkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            con.Open();
            int count = (int)cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool searchKH(string tenKH)
        {
            string sql = @"select count (*) from KHACHHANG where HOTEN = @tenkh";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenkh", tenKH);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return (count >= 1);
        }
        public int checkSL(string maMH)
        {
            string sql = @"select SOLUONG from MATHANG where MAMH=@mmh";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mmh", maMH);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            int count = 0;
            count = Convert.ToInt32(read["SOLUONG"].ToString());
            con.Close();
            return count;
            
        }
        public double checkDonGia(string maMH)
        {
            string sql = @"select DONGIA from MATHANG where MAMH=@mmh";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mmh", maMH);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            double count = 0;
            count = Convert.ToDouble(read["DONGIA"].ToString());
            con.Close();
            return count;

        }
        public bool insertBH(BHang bh)
        {
            string sql = @"insert into BANHANG values (@mamh, @makh, @nb, @nt, @sl)";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mamh", bh.MatHang);
            cmd.Parameters.AddWithValue("@makh", bh.KhachHang);
            cmd.Parameters.AddWithValue("@nb", bh.NgayBan);
            cmd.Parameters.AddWithValue("@nt", bh.NgayTra);
            cmd.Parameters.AddWithValue("@sl", bh.SoLuong);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        
    }
}