<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BanHang.aspx.cs" Inherits="GK.BanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
        <table style="width:500px; margin: auto">
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Mặt hàng"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMatHang" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Khách hàng"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlKhachHang" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Ngày bán"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNgayBan" runat="server" />
                    <asp:Calendar ID="cld" runat="server" Visible="false" OnSelectionChanged="cld_SelectionChanged"></asp:Calendar>
                    <asp:LinkButton ID="lnkPickdate" runat ="server" OnClick="lnkPickdate_Click" Text="Mở calendar"></asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Ngày trả"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNgayTra" runat="server" />
                    <asp:Calendar ID="Calendar1" runat="server" Visible="false" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                    <asp:LinkButton ID="LinkButton1" runat ="server" OnClick="LinkButton1_Click" Text="Mở calendar"></asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Số lượng"></asp:Label>
                    
                </td>
                <td>
                    <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                    
                </td>
                <td>
                    <asp:Button ID="btnBanHang" runat="server" Text="Bán hàng" OnClick="btnBanHang_Click"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThanhTien" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
