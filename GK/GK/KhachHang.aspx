<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="GK.KhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:700px; margin: auto">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Mã khách hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaKH" runat="server" style="width:180px; height: 25px"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvMaKH" runat="server" ErrorMessage="Bạn chưa nhập mã khách hàng!" ControlToValidate="txtMaKH" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tên khách hàng"></asp:Label>
                    
                </td>
                <td>
                    <asp:TextBox ID="txtTenKH" runat="server" style="width:180px; height: 25px"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvTenKH" runat="server" ErrorMessage="Bạn chưa nhập tên khách hàng!" ForeColor="Red" ControlToValidate="txtTenKH"></asp:RequiredFieldValidator>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Số điện thoại"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSDT" runat="server" style="width:180px; height: 25px"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvSDT" runat="server" ErrorMessage="Bạn chưa nhập số điện thoại" ForeColor="Red" ControlToValidate="txtSDT"></asp:RequiredFieldValidator>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                </td>
                <td>
                    <div>
                        <asp:Button ID="btnThem" runat="server" Text="Thêm" Width="50px" Height="30px" OnClick="btnThem_Click"/>
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" style="margin-left: 15px" Width="50px" Height="30px" OnClick="btnSua_Click"/>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="grvKH" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvKH_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="MAKH" HeaderText="Mã khách hàng" />
                            <%--<asp:HyperLinkField DataTextField="HOTEN" HeaderText="Họ tên" NavigateUrl="~/BanHang.aspx" />--%>
                            <asp:BoundField DataField="HOTEN" HeaderText="Họ tên" />
                            <asp:BoundField DataField="SDT" HeaderText="Số điện thoại" />
                            
                            <asp:CommandField ShowSelectButton="True" />
                            
                        </Columns>
                    </asp:GridView>
                    
                 </td>   
               </tr>
            <tr>
                <td>     
                    <asp:TextBox ID="txtTim" runat="server" placeholder="Nhập tên cần tìm!" Width="180px" Height="25px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnTim" runat="server" Text="Tìm" Width="50px" Height="30px" OnClick="btnTim_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
