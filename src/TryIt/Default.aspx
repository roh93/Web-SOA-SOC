<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <br /><br /><br />
         <h2>DES Encryption and Decryption of a string</h2>
        <br />
        <p> <b> Gives encrypted string from plain text</b></p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Enter String For Encryption"></asp:Label>
        <asp:TextBox ID="encryptTB" runat="server" Height="16px" Width="160px"></asp:TextBox>
        <asp:Label ID="encryptedLabel" runat="server" Text="Encrypted String" ></asp:Label>
    </p>
    <pre>   <asp:Button ID="encryptButton" runat="server" Text="Encrypt" OnClick="encryptButton_Click" /></pre>
    <br /><br />
        <p> <b> Gives decrypted string from encrpted text generated from the same application</b></p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Enter String For Decryption"></asp:Label>
        <asp:TextBox ID="decryptTB" runat="server" Height="16px" Width="160px"></asp:TextBox>
        <asp:Label ID="decryptLabel" runat="server" Text="Decrypted String" ></asp:Label>
    </p>
    <pre>   <asp:Button ID="decryptButton" runat="server" Text="Decrypt" OnClick="decryptButton_Click" /></pre>
    <br /><br />
    </form>
</body>
</html>
