<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomerWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class=" test">
        <h1>AUTHENTICATION</h1>

    <asp:Label ID="label1" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
        <br><br>
    <asp:Label ID="label2" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        <br> <br> 
        <asp:Button ID="loginButton" runat="server" Text="LOGIN" OnClick="loginButton_Click" />
        <br> <br> 
        <asp:Label ID="labelmessage" runat="server" Text=""></asp:Label>
         <br> <br>
        <br>

    </div>
</asp:Content>
