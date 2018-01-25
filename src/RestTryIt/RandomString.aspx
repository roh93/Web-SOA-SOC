<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RandomString.aspx.cs" Inherits="RandomString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <asp:Label ID ="promptlabel" runat="server" Text="Enter length of random string"></asp:Label>
            <asp:TextBox ID="searchTB" runat="server"></asp:TextBox>
            <asp:Button ID ="searchButton" runat="server" Text="Go" OnClick="searchButton_Click" />
        </div>
        <br /><br />
        <asp:Label ID ="stringLabel" runat="server" Text="String"></asp:Label>
    </form>
</body>
</html>
