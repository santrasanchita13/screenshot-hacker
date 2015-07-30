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
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Class1 class1 = new Class1();
        SqlConnection con = new SqlConnection(class1.conn);
        con.Open();
        SqlCommand com = new SqlCommand("select uid, upwd, uname from users where uid='" + Convert.ToString(TextBox1.Text)+"'", con);
        SqlDataReader sdr;
        sdr = com.ExecuteReader();
        if (sdr.Read() != true)
        {
            Label1.Visible = true;
            Label1.Text = "User Name not found";
            con.Close();
        }
        else
        {
            if (sdr[1].ToString().CompareTo(Convert.ToString(TextBox2.Text)) != 0)
            {
                Label1.Visible = true;
                Label1.Text = "User Name and Password do not match";
                con.Close();
            }
            else
            {
                Session ["home"] = sdr[0].ToString();
                Response.Redirect("Home1.aspx");
                con.Close();
            }
        }
        
    }
}
