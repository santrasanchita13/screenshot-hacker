<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="_Default" Title="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
        .auto-style1
        {
            width: 385px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>

    <table class="style8">
        <tr>
            <td align="center" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 169px;">Registration</h1></td>
        </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
            User Name:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label1" 
                    Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="User Name Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
            Name:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
            Password:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Password Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
            Confirm Password:
            </td>
            <td align="left">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox4" ControlToValidate="TextBox5" 
                    ErrorMessage="Passwords do not match"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">Email Id:</td>
            <td align="left">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Email Id Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">Company Name:</td>
            <td align="left">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
                &nbsp;</td>
            <td align="left">
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" ForeColor="#669900" />
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style1">
                &nbsp;</td>
            <td align="left">
                <asp:Label ID="Label2" runat="server" Text="Label2" Visible="False"></asp:Label>
            </td>
        </tr>
        </table>

</div>
</asp:Content>

