<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Button ID="memRegButton" runat="server" Text="Member Registraion" CssClass="buttons" />
        <asp:Button ID="memLoginButton" runat="server" Text="Member Login" CssClass="buttons" />
        <asp:Button ID="staffLoginButton" runat="server" Text="Staff Login" CssClass="buttons"/>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="toMemPage" runat="server" Text="To Member Page" CssClass="buttons" OnClick="toMemPage_Click" />
        <asp:Button ID="toStaffPage" runat="server" Text="To Staff Page" CssClass="buttons" />
    </div>
</asp:Content>
