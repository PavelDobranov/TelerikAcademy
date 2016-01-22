<%@ Page Title="Summator" Language="C#" ClientIDMode="Static" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Summator.aspx.cs" Inherits="SummatorWebForms.Summator" %>

<asp:Content ID="Summator" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>ASP.NET WebForms Summator</h1>
    </div>
    <div class="form-group">
        <label for="TextBoxFirstNumber" class="col-md-2 control-label">First Number</label>
        <div class="col-md-10">
            <asp:TextBox ID="TextBoxFirstNumber" CssClass="form-control" runat="server" required="reqired"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBoxSecondNumber" class="col-md-2 control-label">Second Number</label>
        <div class="col-md-10">
            <asp:TextBox ID="TextBoxSecondNumber" CssClass="form-control" runat="server" required="reqired"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-2">
            <asp:Button ID="ButtonSum" CssClass="btn btn-success" runat="server" Text="Sum" OnClick="ButtonSum_Click" />
        </div>
        <div class="col-md-10">
            <asp:TextBox ID="TextBoxSum" CssClass="form-control" disabled="true" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
