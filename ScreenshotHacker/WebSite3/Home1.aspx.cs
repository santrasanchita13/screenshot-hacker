using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["home"].ToString();
        
    }
    protected void Label1_Load(object sender, EventArgs e)
    {
        
    }
    protected void HyperLink3_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        try
        {
            String remoteUri = AppDomain.CurrentDomain.BaseDirectory + "/Application.zip";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "/Application1.zip";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(remoteUri, fileName);
            Label2.Visible = true;
            Label2.Text = "Download complete";
        }
        catch(Exception)
        {
            Label2.Visible = true;
            Label2.Text = "Could not Download Application";
        }
    }
}
