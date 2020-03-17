<%@ Page Title="" Language="C#" MasterPageFile="~/Census2021.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="WebApplication3.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 232px;
        }
        .auto-style5 {
            width: 187px;
        }
        .auto-style6 {
            width: 188px;
        }
        .auto-style7 {
            width: 187px;
            height: 64px;
        }
        .auto-style8 {
            width: 188px;
            height: 64px;
        }
        .auto-style9 {
            width: 232px;
            height: 64px;
        }
        .auto-style10 {
            height: 64px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Create Application" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="House Hold Member"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="*Required Field" ForeColor="Red" Font-Bold="True" Style="float:right"></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style7">* First Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="FirstName is Required" ControlToValidate="TextBox1" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8">Middle Name<br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9">* Last Name<br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage=" LastName is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style10">Suffix<br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem>Mr</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                    <asp:ListItem>Mrs</asp:ListItem>
                    <asp:ListItem>Ms</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">* Date of Birth(mm/dd/yyyy)<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="DateOfBirth Is Mandatory" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style6">* Gender<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
       
    </table>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Add Member" Style="float:right" ForeColor="White" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Save and Exit" Style="float:left" ForeColor="White" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" OnClick="Button2_Click" CausesValidation="False" />
    <br />
    <br />

</asp:Content>
