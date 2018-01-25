using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    static String encodedString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void encryptButton_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(encryptTB.Text))
        {
            EncryptionDecryptionService.EncryptDecryptServicesClient encryptionDecryptionService = new EncryptionDecryptionService.EncryptDecryptServicesClient();
            String encryptedString = encryptionDecryptionService.encryptString(encryptTB.Text);
            encodedString = encryptedString;
            encryptedLabel.Text = encryptedString;
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "Enter a string to encrypt", true);
        }
    }

    protected void decryptButton_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(decryptTB.Text))
        {
            if (decryptTB.Text.Equals(encodedString))
            {
                EncryptionDecryptionService.EncryptDecryptServicesClient encryptionDecryptionService = new EncryptionDecryptionService.EncryptDecryptServicesClient();
                String decryptedString = encryptionDecryptionService.decryptString(decryptTB.Text);
                decryptLabel.Text = decryptedString;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "This string was not encrypted by this application", true);
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "Enter a string to decrypt", true);
        }
    }
}