<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisConnectedArchitecture_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <table class="auto-style1">
            <tr>
                <td>Id</td>
                <td colspan="3">
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Firstname</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>LastName</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Salary</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>RegNo</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Department</td>
                <td class="auto-style3" colspan="3">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="new Record" Width="131px" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Refresh" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                </td>
                <td class="auto-style2" colspan="3">Grid Update:</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
      
    </form>
</body>
</html>
