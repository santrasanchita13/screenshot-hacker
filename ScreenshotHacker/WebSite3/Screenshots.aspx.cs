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
using OpenPop.Common;
using OpenPop.Mime;
using OpenPop.Pop3;
using System.Collections.Generic;
using System.IO;


public partial class _Default : System.Web.UI.Page
{
    public String email1;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label3.Visible = false;
        Screenshot3.EnableCaching = false;
        GridView1.DataBind();
        Screenshot3.EnableCaching = true;
        try
        {
            Class1 class1 = new Class1();
            SqlConnection con2 = new SqlConnection(class1.conn);
            con2.Open();
            SqlCommand com2 = new SqlCommand("select email from users where uid='" + Session["home"].ToString() + "'", con2);
            SqlDataReader sdr1;
            sdr1 = com2.ExecuteReader();
            sdr1.Read();
            email1 = sdr1[0].ToString();
            
            con2.Close();
        }
        catch (Exception)
        {
            Label3.Visible = true;
            Label3.Text = "";
        }
    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            Class1 class1 = new Class1();
            SqlConnection con2 = new SqlConnection(class1.conn);
            con2.Open();
            SqlCommand com1 = new SqlCommand("select email from screenshots where empid='" + Convert.ToString(TextBox3.Text) + "'", con2);
            SqlDataReader sdr1;
            sdr1 = com1.ExecuteReader();
            sdr1.Read();
                      
            if (sdr1.FieldCount > 0)
            {
                var client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(email1, Convert.ToString(TextBox4.Text));
                
                var count = client.GetMessageCount();
                
                for (int i = count; i >= (count - 10); i--)
                {
                    Message message = client.GetMessage(i);
                    String from = Convert.ToString(message.Headers.From.Address);
                    if (from.Equals(sdr1[0]))
                    {
                        String pathString = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Convert.ToString(TextBox3.Text));

                        List<MessagePart> attachments = message.FindAllAttachments();
                        foreach (MessagePart attachment in attachments)
                        {
                            String filename = attachment.FileName;

                            byte[] Content = attachment.Body;
                            MemoryStream ms = new MemoryStream(Content);
                            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                            String path1 = pathString + "\\" + filename;
                            img.Save(path1);
                            SqlConnection con4 = new SqlConnection(class1.conn);
                            con4.Open();
                            try
                            {
                                SqlCommand com = new SqlCommand("insert into images values ('" + Convert.ToString(TextBox3.Text) +"/"+ filename + "', '" + Convert.ToString(TextBox3.Text) + "')", con4);
                                int i1 = com.ExecuteNonQuery();
                            }
                            catch(Exception)
                            {
                                func3();
                            }
                            con4.Close();
                        }
                    }
                }
                con2.Close();
                func3();
            }
            
        }
        catch(Exception)
        {
            func3();
            Label3.Visible = true;
            Label3.Text = "";
        }
    }
    

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int rindex = e.NewSelectedIndex;
        Class1 class1 = new Class1();
        SqlConnection con5 = new SqlConnection(class1.conn);
        con5.Open();
        SqlCommand com5 = new SqlCommand("delete from images where imageid='" + Convert.ToString(GridView1.Rows[rindex].Cells[0].Text) + "';", con5);
        try
        {
            int i = com5.ExecuteNonQuery();
            if (i != 0)
            {
                Screenshot3.EnableCaching = false;
                GridView1.DataBind();
                Screenshot3.EnableCaching = true;
                Console.WriteLine("successful");
                Label3.Visible = true;
                Label3.Text = "Deleted from database";
                con5.Close();
            }
        }
        catch (Exception)
        {

            Label3.Visible = true;
            Label3.Text = "Row not found";
            con5.Close();
        }
    }
    protected void GridView1_Load(object sender, EventArgs e)
    {
        
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }
    protected void func3()
    {
        try
        {
            GridView1.Visible = true;
            Screenshot3.EnableCaching = false;
            GridView1.DataBind();
            Screenshot3.EnableCaching = true;
            if (GridView1.Rows.Count < 1)
            {
                Label3.Visible = true;
                Label3.Text = "Employee not found";

            }
        }
        catch(Exception)
        {
            Label3.Visible = true;
            Label3.Text = "Employee not found";
        }
    }
}
