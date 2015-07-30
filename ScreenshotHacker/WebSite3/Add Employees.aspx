<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Add Employees.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 50%;
        }
        .auto-style2
        {
            height: 60px;
        }
        .auto-style3
        {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td align="center" class="auto-style2" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 169px;">Add Employee</h1></td>
        
        </tr>
        <tr>
            <td align="right" class="auto-style3">Employee Id:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Employee Id Mandatory"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Employee Name:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Designation:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Contact no:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Email Id:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Working on project:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">&nbsp;</td>
            <td align="left" class="auto-style1">
                <asp:Button ID="ButtonAdd" runat="server" Text="Add" ForeColor="#669900" OnClick="ButtonAdd_Click" />
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">&nbsp;</td>
            <td align="left" class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="auto-style2" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 294px;">Edit Employee Information</h1></td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">Enter Employee id:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">&nbsp;</td>
            <td align="left" class="auto-style1">
                <asp:Button ID="Button1" runat="server" CausesValidation="False" Text="Search" OnClick="Button1_Click" ForeColor="#669900" />
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">
                
            </td>
            <td align="left" class="auto-style1">
                &nbsp;</td>
        </tr>
        </table>
    <asp:HyperLink ID="HyperLink5" runat="server">
    <table style="width: 100%">
        <tr>
            <td align="right" class="auto-style4">Employee Name:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">Designation:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">Contact no:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">Email id:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">Working on project:</td>
            <td align="left" class="auto-style1">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">&nbsp;</td>
            <td align="left" class="auto-style1">
                <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Update" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
    </asp:HyperLink>
</asp:Content>

