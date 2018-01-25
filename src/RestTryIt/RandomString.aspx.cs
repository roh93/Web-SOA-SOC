using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RandomString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void searchButton_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(searchTB.Text))
        {
            Uri baseUri = new Uri("http://webstrar47.fulton.asu.edu/page6/Service.svc");
            UriTemplate myTemplate = new UriTemplate("strlen?x={Length}");
            Uri completeUri = myTemplate.BindByPosition(baseUri, searchTB.Text);
            WebClient channel = new WebClient();
            byte[] abc = channel.DownloadData(completeUri);
            Stream strm = new MemoryStream(abc);
            DataContractSerializer obj = new DataContractSerializer(typeof(string));
            string randString = obj.ReadObject(strm).ToString();
            stringLabel.Text = randString;
        }  

    }
}