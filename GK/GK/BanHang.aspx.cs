using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GK
{
    public partial class BanHang : System.Web.UI.Page
    {
        QLBHADO qlbh = new QLBHADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                ddlMatHang.DataSource = qlbh.getTable("select * from MATHANG");
                ddlMatHang.DataTextField = "TENMH";
                ddlMatHang.DataValueField = "MAMH";
                ddlKhachHang.DataSource = qlbh.getTable("select * from KHACHHANG");
                ddlKhachHang.DataTextField = "HOTEN";
                ddlKhachHang.DataValueField = "MAKH";
                Page.DataBind();
            }
        }

        protected void lnkPickdate_Click(object sender, EventArgs e)
        {
            cld.Visible = true;
        }

        protected void cld_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayBan.Text = cld.SelectedDate.Date.ToShortDateString();
            cld.Visible = false;
        }

        protected void btnBanHang_Click(object sender, EventArgs e)
        {
            BHang bh = new BHang(ddlMatHang.SelectedValue.ToString(), ddlKhachHang.SelectedValue.ToString(), Convert.ToDateTime(txtNgayBan.Text), Convert.ToDateTime(txtNgayTra.Text), Convert.ToInt32(txtSoLuong.Text));
            //if (qlbh.checkSL(ddlMatHang.SelectedValue.ToString()) >= Convert.ToInt32(txtSoLuong.Text))
            //{
            //    if (qlbh.insertBH(bh))
            //    {
            //        lblThongBao.Text = "Thêm thành công";
            //        double tt = Convert.ToInt32(txtSoLuong.Text) * qlbh.checkDonGia(ddlMatHang.SelectedValue.ToString());
            //        lblThanhTien.Text = "Thành tiền phải trả: " + tt.ToString();
            //    }
            //    else
            //    {
            //        lblThongBao.Text = "Không thêm được";
            //    }
            //}
            //else
            //{
            //    lblThongBao.Text = "Vượt số lượng có sẵn";
            //}
            if (Convert.ToDateTime(txtNgayBan.Text) <= Convert.ToDateTime(txtNgayTra.Text))
            {
                if (qlbh.insertBH(bh))
                {
                    lblThongBao.Text = "thêm thành công";
                    TimeSpan Time = Convert.ToDateTime(txtNgayTra.Text) - Convert.ToDateTime(txtNgayBan.Text);
                    int TongSoNgay = Time.Days;
                    double tt = TongSoNgay * qlbh.checkDonGia(ddlMatHang.SelectedValue.ToString());
                    lblThanhTien.Text = "Thành tiền phải trả: " + tt.ToString();
                }
                else
                {
                    lblThongBao.Text = "Không thêm được";
                }
            }
            else
            {
                lblThongBao.Text = "Ngày trả phải lớn hơn ngày bán";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayTra.Text = Calendar1.SelectedDate.Date.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }
    }
}