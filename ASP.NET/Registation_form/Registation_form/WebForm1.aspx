<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registation_form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 338px;
        }
        .auto-style4 {
            width: 338px;
            text-align: left;
        }
        .auto-style5 {
            margin-left: 32px;
        }
        .auto-style6 {
            color: #993399;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <span class="auto-style6"><strong>mkpits solution</strong></span><table class="auto-style2">
                <tr>
                    <td class="auto-style4">enter number1<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">enter number2<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Result" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
