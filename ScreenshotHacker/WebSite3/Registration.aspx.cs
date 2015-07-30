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
        Label2.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0)
        {
            Label1.Visible = true;
            Label1.Text = "User Name Mandatory.";
        }
        Class1 class1 = new Class1();
        SqlConnection con = new SqlConnection(class1.conn);
        con.Open();
        SqlCommand com = new SqlCommand("insert into users values ('" + Convert.ToString(TextBox1.Text) + "', '" + Convert.ToString(TextBox2.Text) + "', '" + Convert.ToString(TextBox4.Text) + "', '" + Convert.ToString(TextBox3.Text) + "', '" + Convert.ToString(TextBox6.Text) + "')", con);
        try
        {
            int i = com.ExecuteNonQuery();
           if(i!=0) {
            Console.WriteLine("successful");
            Label2.Visible = true;
            Label2.Text = "Registration Successful!";
            con.Close();
           }
        }
        catch (Exception)
        {
            
            Label1.Visible = true;
            Label1.Text = "User Name already exists.";
            con.Close();
        }
        
    }
}
