<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConferenceRegistration.aspx.cs" Inherits="Zaj04.ConferenceRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" DefaultMode="Insert" ItemType="Zaj04.ViewModels.ConferenceViewModel" OnItemInserted="FormView1_ItemInserted">
        <InsertItemTemplate>
            <div class="form-group">
            <label>AuthorName:</label>
                <asp:TextBox ID="AuthorNameDynamicControl" CssClass="form-control" runat="server" Text="<%# BindItem.AuthorFirstName %>"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="AuthorNameDynamicControl" CssClass="text-danger" runat="server" ErrorMessage="Required" ValidationGroup="Insert"></asp:RequiredFieldValidator>
            </div>
            AuthorLastName:
            <asp:DynamicControl ID="AuthorLastNameDynamicControl" runat="server" DataField="AuthorLastName" Mode="Insert" ValidationGroup="Insert" />
            <br />
            AuthorEmail:
            <asp:DynamicControl ID="AuthorEmailDynamicControl" runat="server" DataField="Email" Mode="Insert" ValidationGroup="Insert" />
            <br />
            SubAuthorName:
            <asp:DynamicControl ID="SubAuthorNameDynamicControl" runat="server" DataField="ArticleAbstract" Mode="Insert" ValidationGroup="Insert" />
            <br />
            SubAuthorLastName:
            <asp:DynamicControl ID="SubAuthorLastNameDynamicControl" runat="server" DataField="ArticleTitle" Mode="Insert" ValidationGroup="Insert" />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" ValidationGroup="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <EmptyDataTemplate>
            Dziękujemy
            <asp:LinkButton runat="server" ID="InsertButton" CausesValidation="true" CommandName="New">Dodaj nowy</asp:LinkButton>
        </EmptyDataTemplate>
    </asp:FormView>
    <asp:ObjectDataSource EnablePaging="true" ID="ObjectDataSource1" runat="server" DataObjectTypeName="Zaj04.ViewModels.ConferenceViewModel" InsertMethod="Register" OldValuesParameterFormatString="original_{0}" SelectMethod="Get" TypeName="Zaj04.BLL.ConferenceService" SelectCountMethod="GetCount"></asp:ObjectDataSource>
    <asp:GridView CssClass="table table-striped" ID="GridView1" runat="server" PageSize="2" AllowPaging="True" DataSourceID="ObjectDataSource1" ></asp:GridView>
</asp:Content>
