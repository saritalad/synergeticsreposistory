<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADO_SP_StoredProcedure_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 686px;
            height: 283px;
            background-color: #FFFF99;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 114px;
        }
        .auto-style4 {
            height: 162px;
        }
        .auto-style5 {
            width: 400px;
            background-color: #FFCCFF;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            text-align: center;
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="5">
                    <asp:Label ID="Label1" runat="server" Text="Category Crud Disconnected"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="CategoryName"></asp:Label>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="CategoryId"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Search" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="delete" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Refresh" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4" colspan="4">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
       
    <table class="auto-style5">
        <tr>
            <td class="auto-style7" colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="DataRelation" Font-Size="20pt"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Load" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style6">
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView3" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
       
    </form>
    </body>
</html>
