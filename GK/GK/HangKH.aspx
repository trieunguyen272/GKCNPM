<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HangKH.aspx.cs" Inherits="GK.HangKH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:GridView ID="grvHangKH" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MAMH" HeaderText="Mã mặt hàng" />
                <asp:BoundField DataField="MAKH" HeaderText="Mã khách hàng" />
                <asp:BoundField DataField="NGAYBAN" HeaderText="Ngày bán" />
                <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            </Columns>
        </asp:GridView>
        
    </div>
    </form>
</body>
</html>
