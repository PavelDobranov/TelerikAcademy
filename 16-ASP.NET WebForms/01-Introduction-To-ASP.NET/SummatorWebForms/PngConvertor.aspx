<%@ Page Title="PNG Convertor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PngConvertor.aspx.cs" Inherits="SummatorWebForms.PngConvertor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>ASP.NET WebForms PNG Convertor</h1>
    </div>
    <asp:TextBox runat="server" ID="TextBoxInput" CssClass="form-control"></asp:TextBox>
    <asp:Button runat="server" ID="ButtonConvert" CssClass="btn btn-success" Text="Convert" OnClick="ButtonConvert_Click" />
    <span>==></span>
    <asp:Image runat="server" ID="ImageResult" />
</asp:Content>
