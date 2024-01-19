<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="add_sub_form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 20px;
        }
        .auto-style3 {
            margin-left: 18px;
        }
        .auto-style4 {
            margin-left: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>enter number1<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>enter number2<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>enter operator<asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="Result" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
