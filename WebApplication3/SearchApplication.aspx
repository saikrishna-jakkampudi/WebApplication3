<%@ Page Title="" Language="C#" MasterPageFile="~/SearchHome.Master" AutoEventWireup="true" CodeBehind="SearchApplication.aspx.cs" Inherits="WebApplication3.SearchApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            height: 236px;
        }
        .auto-style4 {
            width: 402px;
            height: 147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="User Search" Font-Bold="True" Font-Underline="True"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Use any combination of fileds to search through all customers" Font-Bold="False" EnableTheming="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False"></asp:Label>
    <br />
    <br />
    <table class="auto-style4">
        <tr>
            <td>First Name<br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>Last Name<br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        
        </tr>
        <tr>
            <td>DOB<br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td>Application ID<br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
            </td>
            
       
        </tr>
    </table>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" Height="76px" AllowPaging="true" OnPageIndexChanging="GridView1_PageIndexChanging" Width="713px">
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Search" BackColor="#009900" BorderColor="#009900" BorderStyle="Groove" Font-Bold="True" Width="145px" OnClick="Button1_Click" />

</asp:Content>
