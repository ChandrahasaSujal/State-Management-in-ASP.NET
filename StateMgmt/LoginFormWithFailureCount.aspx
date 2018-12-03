<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFormWithFailureCount.aspx.cs" Inherits="StateMgmt.LoginFormWithFailureCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>User Name:</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                    <td>
                        <input id="btnReset" type="reset" value="Reset" /></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
