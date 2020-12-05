using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace GK
{
    public partial class KhachHang : System.Web.UI.Page
    {
        QLBHADO qlbh = new QLBHADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvKH.DataSource = qlbh.getTable("select * from KHACHHANG");
                Page.DataBind();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (qlbh.checkMaKH(txtMaKH.Text))
            {
                lblThongBao.Text = "Mã khách hàng đã tồn tại!";
            }
            else
            {
                KHang kh = new KHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text);
                if (qlbh.insertKH(kh))
                {
                    lblThongBao.Text = "Thêm thành công";
                    grvKH.DataSource = qlbh.getTable("select * from KHACHHANG");
                    grvKH.DataBind();
                }
                else
                {
                    lblThongBao.Text = "Không thêm được";
                }
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            if (qlbh.searchKH(txtTim.Text))
            {
                lblThongBao.Text = "Tìm thành công";
                
            }
            else
            {
                lblThongBao.Text = "Không tìm được";
            }
            grvKH.DataSource = qlbh.getTable("select * from KHACHHANG where HOTEN = N'" + txtTim.Text + "'");
            grvKH.DataBind();
        }

        protected void grvKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = grvKH.SelectedRow.Cells[0].Text;
            txtMaKH.ReadOnly = true;
            txtTenKH.Text = grvKH.SelectedRow.Cells[1].ToolTip;
            txtSDT.Text = grvKH.SelectedRow.Cells[2].Text;
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            KHang kh = new KHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text);
            if (qlbh.updateKH(kh))
            {
                lblThongBao.Text = "Sửa thành công";
                grvKH.DataSource = qlbh.getTable("select * from KHACHHANG");
                grvKH.DataBind();
            }
            else
            {
                lblThongBao.Text = "Không sửa được";
            }
        }
    }
}