<html>
  <body>
    <h1> Login to access Staff page
   </h1> <hr>
    <form runat="server">
      <table cellpadding=“4">
        <tr>
          <td> User Name:  </td>
          <td>
            <asp:TextBox ID= "txtUserName" RunAt="server" />
          </td>
        </tr>
        <tr><td> Password: </td><td>
            <asp:TextBox ID="TextBox1" TextMode="password"
              RunAt="server" />
		</td>
        </tr>
         <tr>
		<td>
			<asp:Button Text= "btnLogin" OnClick="LoginFunc"  RunAt="server" />
		</td>
</tr>
      </table>
</form>
    <hr>
    <h3><asp:Label ID="Output"  RunAt="server"/> </h3>
  </body>
</html>
<script language="C#" runat="server">
  void LoginFunc(Object sender, EventArgs e)
  {
      if (myAuthenticate (UserName.Text, Password.Text))
          FormsAuthentication.RedirectFromLogin(UserName.Text, Persistent.Checked);
      else
          Output.Text = "Invalid login";
  }

    bool myAuthenticate (string username, string password) {
	string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Users.xml");
        if (File.Exists(fLocation))
        {
            FileStream FS= new FileStream(fLocation, FileMode.Open);
            XmlDocument xd = new XmlDocument();
            xd.Load(FS);
            XmlNode node = xd;
            XmlNodeList children = node.ChildNodes;
		foreach (XmlNode child in children)
		{
			// use hash function if the credential is hashed
			// check if the username and password exist in the XML file;
		}
	}
}


</script>

