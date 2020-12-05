using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GK
{
    public class KHang
    {
        private string maKH, tenKH, sodt;
        public KHang (string ma, string ten, string sdt)
        {
            maKH = ma;
            tenKH = ten;
            sodt = sdt;
        }
        public string MAKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TENKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public string SDT
        {
            get { return sodt; }
            set { sodt = value; }
        }
    }
}