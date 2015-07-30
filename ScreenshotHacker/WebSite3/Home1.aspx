<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Home1.aspx.cs" Inherits="_Default" Title="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" width="34%" align="center">
                <asp:Image ID="Image6" runat="server" ImageUrl="~/Pictures/1b.jpg" Height="410px" Width="304px" />
            </td>
            <td><div style="font-size:medium; width: 366px; margin-left: 0px; font-family:Calibri; color:cornflowerblue">
<p align="center">
    Welcome <asp:Label ID="Label1" runat="server" OnLoad="Label1_Load"></asp:Label>.
    <br />
    To start managing your employees. Simply 
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Download</asp:LinkButton>
    &nbsp;our software and install it in all your employee computers.
<br />
    That's all!! You will start recieving screenshots of your employees' progress in your email inbox.
    <br />
    You can view and manage the screenshots in our <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Screenshots.aspx" OnLoad="HyperLink3_Load">Screenshots</asp:HyperLink> &nbsp; tag.</p>
                <p align="center">
                    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
</p>
</div></td>
            <td width="33%" align="center">
                <asp:Image ID="Image5" runat="server" ImageUrl="~/Pictures/1a.jpg" Height="410px" Width="304px" />
            </td>
        </tr>
    </table>
</asp:Content>

