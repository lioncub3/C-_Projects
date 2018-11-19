<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="RotatorDataSource" CssClass="MyAdRotator"/>
    <asp:XmlDataSource ID="RotatorDataSource" runat="server" DataFile="~/Rotator.xml"></asp:XmlDataSource>
</asp:Content>