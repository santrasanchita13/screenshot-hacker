﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text = Session["home"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Timeout = 10;
        Response.Redirect("Home.aspx");
    }
    protected void Label1_Load(object sender, EventArgs e)
    {

    }
}
