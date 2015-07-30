<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Screenshots.aspx.cs" Inherits="_Default" Title="Screenshots" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
        }
        .auto-style3
        {
        }
        .auto-style4
        {
            width: 395px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
    <table class="auto-style1">
        <tr>
            <td align="center" colspan="2"><h1 style="font-family: Calibri; font-size: x-large; font-weight: bold; color: #808000; background-color: #FBCDA4; border-style: double; border-width: medium; width: 335px;">Search Employee Screenshots</h1></td>
        
        </tr>
        <tr>
            <td align="right" class="auto-style4">Employee Id:</td>
            <td align="left">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">Email password(To download screenshots):</td>
            <td align="left">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">&nbsp;</td>
            <td align="left">
                <asp:Button ID="ButtonSearch" runat="server" ForeColor="#669900" Text="Search" OnClick="ButtonSearch_Click" CausesValidation="False" />
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style4">&nbsp;</td>
            <td align="left">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="auto-style3" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="imageid" DataSourceID="Screenshot3" EnableModelValidation="True" Visible="False" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnLoad="GridView1_Load" OnRowDataBound="GridView1_RowDataBound" >
                    <Columns>
                        <asp:BoundField DataField="imageid" HeaderText="Screenshots" ReadOnly="True" SortExpression="imageid" InsertVisible="True" />
                        <asp:ImageField DataImageUrlField="imageid" DataImageUrlFormatString="/WebSite3/{0}" HeaderText="Images">
                            <ControlStyle Height="160px" Width="160px" />
                        </asp:ImageField>
                        <asp:CommandField SelectText="Delete" ShowSelectButton="True" CausesValidation="False" />
                        <asp:HyperLinkField DataNavigateUrlFields="imageid" DataNavigateUrlFormatString="/WebSite3/{0}" Text="View" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="Screenshot3" runat="server" ConnectionString="<%$ ConnectionStrings:ScreenshotConnectionString %>" SelectCommand="SELECT [imageid] FROM [images] WHERE ([folderid] = @folderid)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox3" Name="folderid" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

