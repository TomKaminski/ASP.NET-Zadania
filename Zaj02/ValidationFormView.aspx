<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationFormView.aspx.cs" Inherits="Zaj02.ValidationFormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link href="~/Content/bootstrap.css" rel="stylesheet" type="text/css" />
        <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
        <script src="/Scripts/jquery-2.1.3.js"></script>
        <script src="/Scripts/jquery.validate.js"></script>
        <script src="/Scripts/jquery.validate.unobtrusive.js"></script>
        <script src="/Scripts/bootstrap.js"></script>
    </head>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <h2 style="text-align: center; margin-bottom: 30px;">Formularz zgłoszeniowy</h2>
                <div class="row">
                    <div class="col-md-8 col-lg-6 col-sm-12">
                        <div class="form-horizontal">                            
                            <asp:FormView runat="server" ItemType="Zaj02.Infrastructure.Formularz" Width="500px" InsertMethod="ReportSubmit" DefaultMode="Insert"> 
                                <InsertItemTemplate>
                                    <h3 style="font-weight: bold">Autor</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="AuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="AuthorName" CssClass="form-control" Text="<%# BindItem.AuthorName %>"/>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorName"
                                                                        CssClass="text-danger" ErrorMessage="Imię jest wymagane" Display="Dynamic"/>
                                            <asp:RegularExpressionValidator ID="validator1" runat="server" ControlToValidate="AuthorName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Imie jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>                
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="AuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="AuthorLastName" CssClass="form-control" Text="<%# BindItem.AuthorLastName %>"/>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorLastName"
                                                                        CssClass="text-danger" ErrorMessage="Nazwisko jest wymagane" />
                                            <asp:RegularExpressionValidator ID="validator2" runat="server" ControlToValidate="AuthorLastName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Nazwisko jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" Text="<%# BindItem.AuthorEmail %>"/>
                                            <asp:RequiredFieldValidator ID="validator3" runat="server" ControlToValidate="Email"
                                                                        CssClass="text-danger" ErrorMessage="Email jest wymagany" Display="Dynamic"/>
                                            <asp:RegularExpressionValidator ID="validator4" CssClass="text-danger" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" ControlToValidate="Email" runat="server" ErrorMessage="Email jest niepoprawny"></asp:RegularExpressionValidator>  
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Współautor</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="SemiAuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="SemiAuthorName" CssClass="form-control" Text="<%# BindItem.SubAuthorName %>" />
                                            <asp:RegularExpressionValidator ID="validator5" runat="server" ControlToValidate="SemiAuthorName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Imie jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="SemiAuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="SemiAuthorLastName" CssClass="form-control" Text="<%# BindItem.SubAuthorLastName %>" />
                                            <asp:RegularExpressionValidator runat="server" ID="validator6" ControlToValidate="SemiAuthorLastName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Nazwisko jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Opiekun</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="DefenderName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="DefenderName" CssClass="form-control" Text="<%# BindItem.DefenderName %>"/>
                                            <asp:RequiredFieldValidator runat="server" ID="validator7" ControlToValidate="DefenderName"
                                                                        CssClass="text-danger" ErrorMessage="Imię jest wymagane" />
                                            <asp:RegularExpressionValidator runat="server" ID="validator8" ControlToValidate="DefenderName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Imie jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="DefenderLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="DefenderLastName" CssClass="form-control" Text="<%# BindItem.DefenderLastName %>"/>
                                            <asp:RequiredFieldValidator runat="server" ID="validator9" ControlToValidate="DefenderLastName"
                                                                        CssClass="text-danger" ErrorMessage="Nazwisko jest wymagane" />
                                            <asp:RegularExpressionValidator runat="server" ID="validator10" ControlToValidate="DefenderLastName" Display="Dynamic" CssClass="text-danger" ErrorMessage="Nazwisko jest niepoprawne" ValidationExpression="[A-Ża-ż]*"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Uniwersytet/szkoła</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="universytyName" CssClass="col-md-2 control-label">Nazwa</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="universytyName" CssClass="form-control" Text="<%# BindItem.UniversityName %>"/>
                                            <asp:RequiredFieldValidator runat="server" ID="validator11" ControlToValidate="universytyName"
                                                                        CssClass="text-danger" ErrorMessage="Podaj nazwę uczelni/szkoły" />                                            
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="universityAddress" CssClass="col-md-2 control-label">Adres</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="universityAddress" CssClass="form-control" Text="<%# BindItem.UniversityAddress %>" />
                                            <asp:RequiredFieldValidator runat="server" ID="validator12" ControlToValidate="universityAddress"
                                                                        CssClass="text-danger" ErrorMessage="Podaj adres swojej uczelni/szkoły" />
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Referat</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="reportTitle" CssClass="col-md-2 control-label">Tytuł</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="reportTitle" CssClass="form-control" Text="<%# BindItem.ReportTitle %>"/>
                                            <asp:RequiredFieldValidator ID="validator13" runat="server" ControlToValidate="reportTitle"
                                                                        CssClass="text-danger" ErrorMessage="Podaj tytuł referatu" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="reportSummary" CssClass="col-md-2 control-label">Streszczenie</asp:Label>
                                        <div class="col-md-10">
                                            <textarea runat="server" ID="reportSummary" cols="20" rows="2" class="form-control" style="max-width: 280px" value="<%# BindItem.ReportSummary %>"></textarea>
                                            <asp:RequiredFieldValidator runat="server" ID="validator14" ControlToValidate="reportSummary"
                                                                        CssClass="text-danger" ErrorMessage="Streść swój referat" Display="Dynamic"/>
                                        </div>
                                    </div>               
                                    <div class="form-group">
                                        <div class="col-md-offset-2 col-md-10">
                                            <asp:Button runat="server" CommandName="Insert" Text="Wyślij" CssClass="btn btn-default" />
                                        </div>
                                    </div>
                                </InsertItemTemplate> 
                            </asp:FormView>
                        </div>            
                    </div>
                </div>
                <div class="row">
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
                                <asp:Repeater ID="Repeater1" runat="server" ItemType="Zaj02.Infrastructure.Formularz">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Item.AuthorName %> <%# Item.AuthorLastName %></td>
                                            <td><%# Item.AuthorEmail %></td>
                                            <td><%# Item.SubAuthorLastName %> <%# Item.SubAuthorName %></td>
                                            <td><%# Item.DefenderLastName %> <%# Item.DefenderName %></td>
                                            <td><%# Item.ReportTitle %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>                                
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>