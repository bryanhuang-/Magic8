<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Magic8._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <asp:Button ID="fortuneButton" runat="server" Text="Click for fortune!" 
            Width="232px" onclick="fortuneButton_Click" />
        <asp:TextBox ID="fortuneTextBox" runat="server" Width="438px" ReadOnly="True"></asp:TextBox>
    </p>
<p>
        <asp:Label ID="countLabel" runat="server" Text="Fortunes given: 0"></asp:Label>
    </p>
    <p>
        Created by Bryan Huang, Copyright 2013</p>
</asp:Content>
