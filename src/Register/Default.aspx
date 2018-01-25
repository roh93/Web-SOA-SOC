<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label><b>Email</b></label>
    <asp:TextBox ID="emailTB" runat="server" Height="16px" Width="160px"></asp:TextBox>
    </div>
        <br/>
    <div>
    <label><b>Password</b></label>
    <asp:TextBox ID="pwdTB" TextMode="Password" runat="server" />
    </div>
        <br/>
    <div>
    <label><b>Repeat Password</b></label>
    <asp:TextBox ID="cfmpwdTB" TextMode="Password" runat="server" />
    </div>
        <br/><br/>
    <div>
      <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" />
      <asp:Button ID="signupButton" runat="server" Text="Sign Up" OnClick="signupButton_Click" />
    </div>
        <br /><br />
        <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
