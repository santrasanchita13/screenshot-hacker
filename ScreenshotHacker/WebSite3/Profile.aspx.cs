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
        
        Label3.Visible = false;
        Label2.Text = Session["home"].ToString();

        TextBox2.Visible = false;
        TextBox3.Visible = false;
        RequiredFieldValidator1.Enabled = false;
        CompareValidator1.Enabled = false;
        if (TextBox1.Text.Length == 0 || TextBox4.Text.Length == 0 || TextBox5.Text.Length == 0)
        {
            func1();
        }
    }

    protected void func1()
    {
        Class1 class1 = new Class1();
        SqlConnection con = new SqlConnection(class1.conn);
        con.Open();
        String s1 = Convert.ToString(Session["home"]);
        SqlCommand com1 = new SqlCommand("select uname, email, company from users where uid='" + s1 + "';", con);
        SqlDataReader sdr1;
        sdr1 = com1.ExecuteReader();
        sdr1.Read();
        TextBox1.Text = sdr1[0].ToString();
        TextBox4.Text = sdr1[1].ToString();
        TextBox5.Text = sdr1[2].ToString();
        con.Close();
    }

    protected void ButtonSubmit_Click(object sender1, EventArgs e1)
    {
        Class1 class1 = new Class1();
        String t1 = Convert.ToString(TextBox1.Text);
        String t2 = Convert.ToString(TextBox4.Text);
        
        String t3 = Convert.ToString(TextBox5.Text);
        
        String s1 = Convert.ToString(Session["home"]);
        if (TextBox2.Text.Length>0)
        {
            int ib;
            
            SqlConnection con1 = new SqlConnection(class1.conn);
            con1.Open();
            SqlCommand com2 = new SqlCommand("update users set uname='" + t1 + "', email='" + t2 + "', company='" + t3 + "', upwd='" + Convert.ToString(TextBox2.Text) + "' where uid='" + s1 + "';", con1);
            ib = com2.ExecuteNonQuery();
            con1.Close();
            if (ib > 0)
            {
                Label3.Visible = true;
                Label3.Text = "Profile Updated!";
            }
        }
        else
        {
            int ia;
            
            SqlConnection con2 = new SqlConnection(class1.conn);
            con2.Open();
            SqlCommand com3 = new SqlCommand("update users set uname='" + t1 + "', email='" + t2 + "', company='" + t3 + "' where uid='" + s1 + "';", con2);
            ia = com3.ExecuteNonQuery();
            con2.Close();
            if (ia > 0)
            {
                Label3.Visible = true;
                Label3.Text = "Profile Updated";
            }
        }
        func1();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        RequiredFieldValidator1.Enabled = true;
        CompareValidator1.Enabled = true;
        TextBox2.Visible = true;
        TextBox3.Visible = true;
        
    }
}
