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

    protected void cancelButton_Click(object sender, EventArgs e)
    {

    }

    protected void signupButton_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(emailTB.Text) && !String.IsNullOrEmpty(pwdTB.Text) && !String.IsNullOrEmpty(cfmpwdTB.Text))
        {
            if (pwdTB.Text.Equals(cfmpwdTB.Text))
            {
                String filepath = Server.MapPath("Solution Items/TextFile1.txt");
                AccntService.AccountServicesClient accountServices = new AccntService.AccountServicesClient();
                bool status = accountServices.createAccount(emailTB.Text, pwdTB.Text, filepath);
                if (status)
                {
                    StatusLabel.Text = "Account Registered Successfully";
                }
                else
                {
                    StatusLabel.Text = "Account Already Exists!!";
                }
            }
            else
            {
                StatusLabel.Text = "Passwords need to be the same";
            }
        }
        else
        {
            StatusLabel.Text = "All Fields Are Required";
        }
    }
}