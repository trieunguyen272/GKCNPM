﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GK.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:300px; margin: auto">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ BÁN HÀNG"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><a href="MatHang.aspx" style="color: dodgerblue">DANH MỤC MẶT HÀNG</a></td>
                </tr>
                <tr>
                    <td><a href="KhachHang.aspx" style="color: dodgerblue">DANH MỤC KHÁCH HÀNG</a></td>
                </tr>
                <tr>
                    <td><a href="BanHang.aspx" style="color: dodgerblue">BÁN HÀNG</a></td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
