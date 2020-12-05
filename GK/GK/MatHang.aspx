﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="GK.MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: auto">
        <asp:GridView ID="grvMatHang" runat="server" AutoGenerateColumns="False" style="margin-left: 300px; margin-right: auto">
            <Columns>
                <asp:BoundField DataField="MAMH" HeaderText="Mã mặt hàng" />
                <asp:BoundField DataField="TENMH" HeaderText="Tên mặt hàng" />
                <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
                <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
