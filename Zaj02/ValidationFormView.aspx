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
            <div>
                <h2 style="text-align: center; margin-bottom: 30px;">Formularz zgłoszeniowy</h2>
                <div class="row">
                        <div class="col-md-6">
                <div class="form-horizontal">        
                    
                            <asp:FormView runat="server" ItemType="Zaj02.Infrastructure.Formularz" Width="500px" InsertMethod="ReportSubmit" DefaultMode="Insert"> 
                                <InsertItemTemplate>

                                    <h3 style="font-weight: bold">Autor</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="AuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="AuthorName" CssClass="form-control" Text="<%# BindItem.AuthorName %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="AuthorName"/>
                                        </div>
                                    </div>                
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="AuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="AuthorLastName" CssClass="form-control" Text="<%# BindItem.AuthorLastName %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="AuthorLastName"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" Text="<%# BindItem.AuthorEmail %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="AuthorEmail"/>                  
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Współautor</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="SemiAuthorName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="SemiAuthorName" CssClass="form-control" Text="<%# BindItem.SubAuthorName %>" />
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="SubAuth"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="SemiAuthorLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="SemiAuthorLastName" CssClass="form-control" Text="<%# BindItem.SubAuthorLastName %>" />
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="SubAuthorLastName"/>
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Opiekun</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="DefenderName" CssClass="col-md-2 control-label">Imię</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="DefenderName" CssClass="form-control" Text="<%# BindItem.DefenderName %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="DefenderName"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="DefenderLastName" CssClass="col-md-2 control-label">Nazwisko</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="DefenderLastName" CssClass="form-control" Text="<%# BindItem.DefenderLastName %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="DefenderLastName"/>
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Uniwersytet/szkoła</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="universytyName" CssClass="col-md-2 control-label">Nazwa</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="universytyName" CssClass="form-control" Text="<%# BindItem.UniversityName %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="UniversityName"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="universityAddress" CssClass="col-md-2 control-label">Adres</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="universityAddress" CssClass="form-control" Text="<%# BindItem.UniversityAddress %>" />
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="UniversityAddress"/>
                                        </div>
                                    </div>
                                    <h3 style="font-weight: bold">Referat</h3>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="reportTitle" CssClass="col-md-2 control-label">Tytuł</asp:Label>
                                        <div class="col-md-10">
                                            <asp:TextBox runat="server" ID="reportTitle" CssClass="form-control" Text="<%# BindItem.ReportTitle %>"/>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="ReportTitle"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="reportSummary" CssClass="col-md-2 control-label">Streszczenie</asp:Label>
                                        <div class="col-md-10">
                                            <textarea runat="server" ID="reportSummary" cols="20" rows="2" class="form-control" style="max-width: 280px" value="<%# BindItem.ReportSummary %>"></textarea>
                                            <asp:ModelErrorMessage runat="server" ModelStateKey="ReportSummary"/>
                                        </div>
                                    </div>               
                                    <div class="form-group">
                                        <div class="col-md-offset-2 col-md-10">
                                            <asp:Button runat="server" CommandName="Insert" Text="Wyślij" CssClass="btn btn-default" />
                                        </div>
                                    </div>
                                                                    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" ID="valsum1"></asp:ValidationSummary>
                                </InsertItemTemplate> 

                            </asp:FormView>

                        </div>            
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>