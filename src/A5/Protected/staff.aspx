
<head runat="server"> <title>staff page</title> </head>
<body>
    <form id="form1" runat="server">
        <h1>Staff Page of the Camp</h1>
        <div>  
        <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> <br />
        This page contains the information about staff members who will teach 
        and manage the camp. Only authenticated users can access this page .<br /> 
        </div>    
    </form>
</body>
</html>
