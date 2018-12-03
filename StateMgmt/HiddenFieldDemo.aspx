<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFieldDemo.aspx.cs" Inherits="StateMgmt.HiddenFieldDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfHitcount" runat="server" />
            <asp:Button ID="btnHitCount" runat="server" OnClick="btnHitCount_Click" Text="Hit Counter"/>
            <asp:Button ID="btnNextPage" runat="server" PostBackUrl="~/DisplayingCountWithHiddenField.aspx" Text="Next Page" />
        </div>
    </form>
</body>
</html>
