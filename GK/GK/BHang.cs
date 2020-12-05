using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GK
{
    public class BHang
    {
        private string matHang, khachHang;
        private DateTime ngayBan, ngayTra;
        private int soLuongBan;
        public BHang (string mh, string kh, DateTime nb, DateTime nt, int sl)
        {
            matHang = mh;
            khachHang = kh;
            ngayBan = nb;
            ngayTra = nt;
            soLuongBan = sl;
        }
        public string MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }
        public string KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }
        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        public int SoLuong
        {
            get { return soLuongBan; }
            set { soLuongBan = value; }
        }
    }
}