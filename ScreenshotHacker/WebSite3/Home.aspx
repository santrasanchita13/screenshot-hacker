<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" Title="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
            height: 347px;
        }
        .auto-style2
        {
            width: 34%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" width="34%" align="center">
                <asp:Image ID="Image6" runat="server" ImageUrl="~/Pictures/1b.jpg" Height="410px" Width="304px" />
            </td>
            <td><div style="font-size:medium; width: 366px; margin-left: 0px; font-family:Calibri; color:cornflowerblue">
<p align="center">
    Welcome to Screenshot.
    <br />
    We know management is the most important part of any organisation, but it must be difficult to bear the entire responsibility of your company. In most companies, the mamanger faces the most difficult task of monitoring their employees' activities.
    It gets tedious to check on your employees frequently to see their status on the project or whether they are progressing at a good pace. It is also time consuming and slows down the progress rate if the employees have to report to you after every little task.
    If you are facing similar problems, you need not worry any longer because we will do it for you.
<br />
    We present to you Screenshot. Instead of going to the employees to check on the status of your employees, you can do it now sitting from your chamber, home or anywhere in the world.
    <br />
So, what are you waiting for!! 
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx" OnLoad="HyperLink1_Load">Register</asp:HyperLink>&nbsp; now to start using Screenshot.
    </p>
</div></td>
            <td width="33%" align="center">
                <asp:Image ID="Image5" runat="server" ImageUrl="~/Pictures/1a.jpg" Height="410px" Width="304px" />
            </td>
        </tr>
    </table>
</asp:Content>