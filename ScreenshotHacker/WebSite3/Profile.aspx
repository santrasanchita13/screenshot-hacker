<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="_Default" Title="Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 359px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="auto-style1">
        <tr>
            <td align="center" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 169px;">Profile</h1></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                Your User Id is 
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">Name:</td>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">&nbsp;</td>
            <td align="left">
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CausesValidation="False">Change Password</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">Password:</td>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">Confirm Password:</td>
            <td align="left">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox2" ErrorMessage="Passwords do not match" Display="Dynamic" EnableClientScript="False" EnableTheming="False" EnableViewState="False"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">Email Id:</td>
            <td align="left">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="SingleLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Email Id Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">Company:</td>
            <td align="left">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">&nbsp;</td>
            <td align="left">
                <asp:Button ID="ButtonSubmit" runat="server" ForeColor="#669900" OnClick="ButtonSubmit_Click" Text="Submit" EnableTheming="False" EnableViewState="False" />
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">&nbsp;</td>
            <td align="left">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    
</asp:Content>

