using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        Label3.Visible = false;
        HyperLink5.Visible = false;
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Class1 class1 = new Class1();
        SqlConnection con4 = new SqlConnection(class1.conn);
        con4.Open();
        SqlCommand com = new SqlCommand("insert into screenshots values ('" + Convert.ToString(TextBox1.Text) + "', '" + Convert.ToString(TextBox2.Text) + "', '" + Convert.ToString(TextBox3.Text) + "', '" + Convert.ToString(TextBox4.Text) + "', '" + Convert.ToString(TextBox5.Text) + "', '" + Convert.ToString(TextBox6.Text) + "')", con4);
        try
        {
            int i = com.ExecuteNonQuery();
            if (i != 0)
            {
                String folder1 = Convert.ToString(TextBox1.Text);
                String pathString = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folder1);
                System.IO.Directory.CreateDirectory(pathString);
                Console.WriteLine("successful");
                Label2.Visible = true;
                Label2.Text = "Employee Added";
                con4.Close();
                
            }
        }
        catch (Exception)
        {

            Label2.Visible = true;
            Label2.Text = "Employee Id already exists.";
            con4.Close();
        }
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            HyperLink5.Visible = true;
            Class1 class1 = new Class1();
            SqlConnection con2 = new SqlConnection(class1.conn);
            con2.Open();
            SqlCommand com1 = new SqlCommand("select * from screenshots where empid='" + Convert.ToString(TextBox12.Text) + "'", con2);
            SqlDataReader sdr1;
            sdr1 = com1.ExecuteReader();
            sdr1.Read();
            if (sdr1.FieldCount > 0)
            {
                TextBox7.Text = sdr1[1].ToString();
                TextBox8.Text = sdr1[2].ToString();
                TextBox9.Text = sdr1[3].ToString();
                TextBox10.Text = sdr1[4].ToString();
                TextBox11.Text = sdr1[5].ToString();
                con2.Close();
            }
            else
            {
                HyperLink5.Visible = false;
                Label3.Visible = true;
                Label3.Text = "Employee not found";
            }
        }
        catch(Exception)
        {
            HyperLink5.Visible = false;
            Label3.Visible = true;
            Label3.Text = "Employee not found";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String t1 = Convert.ToString(TextBox12.Text);
        String t2 = Convert.ToString(TextBox7.Text);
        String t3 = Convert.ToString(TextBox8.Text);
        String t4 = Convert.ToString(TextBox9.Text);
        String t5 = Convert.ToString(TextBox10.Text);
        String t6 = Convert.ToString(TextBox11.Text);

        int ib;
        try
        {
            Class1 class1 = new Class1();
            SqlConnection con1 = new SqlConnection(class1.conn);
            con1.Open();
            SqlCommand com2 = new SqlCommand("update screenshots set empname='" + t2 + "', designation='" + t3 + "', contact='" + t4 + "', email='" + t5 + "', project='" + t6 + "' where empid='" + t1 + "';", con1);
            ib = com2.ExecuteNonQuery();
            con1.Close();
            if (ib > 0)
            {
                Label3.Visible = true;
                Label3.Text = "Profile Updated!";
            }
        }
        catch(Exception)
        {
            Label3.Text = "Unable to update";
        }
    }
}