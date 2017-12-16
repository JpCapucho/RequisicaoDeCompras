<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RequisicaoAX.Compras.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyLayout" runat="server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Compras <small></small></h3>
                </div>

                <%--<div class="title_right">
                    <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>--%>
            </div>

            <div class="clearfix"></div>

            <div class="row">
                <div class="col-md-6 col-sm-6 col-xs-12">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Comum <small>beta</small></h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Settings 1</a>
                                        </li>
                                        <li><a href="#">Settings 2</a>
                                        </li>
                                    </ul>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">

                            <ul class="treeview">
                                <li><a href="#">
                                    <h4>Requisições de compra</h4>
                                </a>
                                    <ul>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="Mostrar todas as requisições de compra">Todas as requisições de compra</a></li>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="Mostrar requisições de compra preparadas por mim">Requisições de compra preparadas por mim</a></li>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="Mostrar requisições de compra solicitadas para mim">Requisições de compra solicitadas para mim</a></li>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="">Requisições em aberto</a></li>
                                        <li><a href="<%= ResolveUrl("~/compras/requisicao/nova") %>" title="">Criar nova requisição de compra</a></li>
                                    </ul>
                                </li>
                                <br />
                                <li><a href="#">
                                    <h4>Fornecedores</h4>
                                </a>
                                    <ul>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="Mostrar todos os forcedores">Todos os fornecedores</a></li>
                                        <li><a href="<%= ResolveUrl("~/compras/") %>" title="Solicitar um cadastro de fornecedor">Solicitar cadastro de fornecedor</a></li>
                                    </ul>
                                </li>
                            </ul>


                        </div>
                    </div>
                </div>


                <div class="col-md-6 col-sm-6 col-xs-12">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Relatórios <small>beta</small></h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Settings 1</a>
                                        </li>
                                        <li><a href="#">Settings 2</a>
                                        </li>
                                    </ul>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                        </div>
                    </div>
                </div>

                <div class="clearfix"></div>

            </div>
        </div>
    </div>


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
