using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void signinButton_Click(object sender, EventArgs e)
    {

        if (!String.IsNullOrEmpty(emailTB.Text) && !String.IsNullOrEmpty(pwdTB.Text))
        {
            String filepath = Server.MapPath("Solution Items/TextFile1.txt");
            AccntService.AccountServicesClient accountService = new AccntService.AccountServicesClient();
            bool status = accountService.authenticateUser(emailTB.Text, pwdTB.Text, filepath);
            if (status)
            {
                StatusLabel.Text = "Login Successful";
            }
            else
            {
                StatusLabel.Text = "Login Unsucessful, please check password/email.";
            }
        }
        else
        {
            StatusLabel.Text = "Both fields need are mandatory";
        }
    }

    protected void cancelButton_Click(object sender, EventArgs e)
    {

    }
}