<%@ Page Title="Super Strona" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="Zaj02.Validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center; margin-bottom: 30px;">Formularz zgłoszeniowy</h2>
    <div class="form-horizontal">        
        <div class="row">
            <div class="col-md-6">
                <h3 style="font-weight: bold">Autor</h3>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="AuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="AuthorName" CssClass="form-control"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorName"
                                                    CssClass="text-danger" ErrorMessage="Imię jest wymagane" />
                    </div>
                </div>                
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="AuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="AuthorLastName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorLastName"
                                                    CssClass="text-danger" ErrorMessage="Nazwisko jest wymagane" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                                    CssClass="text-danger" ErrorMessage="Email jest wymagany"/>
                        <asp:RegularExpressionValidator CssClass="text-danger" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" ControlToValidate="Email" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email jest niepoprawny"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <h3 style="font-weight: bold">Współautor</h3>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="SemiAuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="SemiAuthorName" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="SemiAuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="SemiAuthorLastName" CssClass="form-control" />
                    </div>
                </div>
                <h3 style="font-weight: bold">Opiekun</h3>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="DefenderName" CssClass="col-md-2 control-label">Imię</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="DefenderName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="DefenderName"
                                                    CssClass="text-danger" ErrorMessage="Imię jest wymagane" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="DefenderLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="DefenderLastName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="DefenderLastName"
                                                    CssClass="text-danger" ErrorMessage="Nazwisko jest wymagane" />
                    </div>
                </div>
                <h3 style="font-weight: bold">Uniwersytet/szkoła</h3>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="universytyName" CssClass="col-md-2 control-label">Nazwa</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="universytyName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="universytyName"
                                                    CssClass="text-danger" ErrorMessage="Podaj nazwę uczelni/szkoły" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="universityAddress" CssClass="col-md-2 control-label">Adres</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="universityAddress" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="universityAddress"
                                                    CssClass="text-danger" ErrorMessage="Podaj adres swojej uczelni/szkoły" />
                    </div>
                </div>
                <h3 style="font-weight: bold">Referat</h3>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="reportTitle" CssClass="col-md-2 control-label">Tytuł</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="reportTitle" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="reportTitle"
                                                    CssClass="text-danger" ErrorMessage="Podaj tytuł referatu" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="reportSummary" CssClass="col-md-2 control-label">Streszczenie</asp:Label>
                    <div class="col-md-10">
                        <textarea runat="server" ID="reportSummary" cols="20" rows="2" class="form-control" style="max-width: 280px"></textarea>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="reportSummary"
                                                    CssClass="text-danger" ErrorMessage="Podaj tytuł referatu" />
                    </div>
                </div>               
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" OnClick="RegisterReport" Text="Register" CssClass="btn btn-default" />
                    </div>
                </div>
            </div>            
        </div>
        <h1>Repeater List</h1>
        <div class="col-md-12">
            <table class="table-striped table">
                <thead>
                    <tr style="font-weight: bold">
                        <td>Autor</td>
                        <td>Email</td>
                        <td>Współautor</td>
                        <td>Opiekun</td>
                        <td>Temat</td>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("AuthorLastName") %> <%# Eval("AuthorName") %></td>
                                <td><%# Eval("AuthorEmail") %></td>
                                <td><%# Eval("SubAuthorLastName") %> <%# Eval("SubAuthorName") %></td>
                                <td><%# Eval("DefenderLastName") %> <%# Eval("DefenderName") %></td>
                                <td><%# Eval("ReportTitle") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>                                
        </div>
        <h1>Angular List</h1>
        <div class="row">
            <div class="col-md-12 center-block">
                <div ng-app="App">
                    <div ng-controller="AppCtrl" ng-init="init()">
                        <table class="table-striped table">
                            <thead>
                                <tr style="font-weight: bold">
                                    <td>Autor</td>
                                    <td>Email</td>
                                    <td>Współautor</td>
                                    <td>Opiekun</td>
                                    <td>Temat</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="item in data">
                                    <td>{{item.AuthorLastName}} {{item.AuthorName}}</td>
                                    <td>{{item.AuthorEmail}}</td>
                                    <td>{{item.SubAuthorLastName}} {{item.SubAuthorName}}</td>
                                    <td>{{item.DefenderLastName}} {{item.DefenderName}}</td>
                                    <td>{{item.ReportTitle}}</td>
                                </tr>
                            </tbody>
                        </table>                    
                    </div>
                </div>
            </div>
        </div>
    </div>    
</asp:Content>