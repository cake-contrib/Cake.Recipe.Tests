<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="PageLabel" Text="What is 2 + 2? Submit to know the answer." runat="server"></asp:Label>
    <asp:Button ID="SubmitButton" Text="Submit" runat="server" OnClick="SubmitButton_Click" />

</asp:Content>
