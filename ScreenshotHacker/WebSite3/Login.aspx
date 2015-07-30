<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" Title="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
        .auto-style1
        {
            width: 379px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <table class="style8">
        <tr>
            <td align="center" style="color:Olive" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 169px;">Login</h1></td>
        </td>
        </tr>
        <tr>
            <td align="right" style="color:Olive" class="auto-style1">
            User Name:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color:Olive" class="auto-style1">
            Password:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
                </td>
            <td align="left">
                <asp:Button ID="Button1" runat="server" Text="Log In" onclick="Button1_Click" ForeColor="#669900" />
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
                &nbsp;</td>
            <td align="left">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Registration.aspx">New User Registration</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
                &nbsp;</td>
            <td align="left">
                <asp:Label ID="Label1" runat="server" ForeColor="#FF0066" Text="Label1" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    
    </div>
</asp:Content>

