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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Class1 class1 = new Class1();
        SqlConnection con = new SqlConnection(class1.conn1);
        con.Open();
        SqlCommand com = new SqlCommand("create database Screenshot;", con);
        SqlCommand com1 = new SqlCommand("use Screenshot;", con);
        SqlCommand com2 = new SqlCommand("create table users (uid varchar(20) not null, uname varchar(20), upwd varchar(20), email varchar(40), company varchar(20), primary key(uid));", con);
        SqlCommand com3 = new SqlCommand("create table images (imageid varchar(300) not null, folderid varchar(20) references screenshots, primary key(imageid));", con);
        SqlCommand com4 = new SqlCommand("create table screenshots (empid varchar(20) not null, empname varchar(20), designation varchar(20), contact varchar(10), email varchar(40), project varchar(20), primary key(empid));", con);
        try
        {
            int i = com.ExecuteNonQuery();
            int i1 = com1.ExecuteNonQuery();
            int i2 = com2.ExecuteNonQuery();
            int i3 = com4.ExecuteNonQuery();
            int i4 = com3.ExecuteNonQuery();
        }
        catch (Exception)
        {
            
            con.Close();
        }
    }
    protected void HyperLink1_Load(object sender, EventArgs e)
    {

    }
    protected void Label1_Load(object sender, EventArgs e)
    {

    }
}
