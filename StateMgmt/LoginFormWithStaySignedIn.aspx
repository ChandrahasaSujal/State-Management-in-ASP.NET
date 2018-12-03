<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFormWithStaySignedIn.aspx.cs" Inherits="StateMgmt.LoginFormWithStaySignedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Login Form</caption>
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
                    <td colspan="2" align="center">
                        <asp:CheckBox ID="cbMsg" runat="server" Text="Stay signed in"/></td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></td>
                    <td>
                        <input type="reset" value="Reset" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
