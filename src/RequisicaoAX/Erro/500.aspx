﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="500.aspx.cs" Inherits="RequisicaoAX.Erro._500" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Error 500 </title>

    <!-- Bootstrap -->
    <link href="/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="/bower_components/nprogress/nprogress.css" rel="stylesheet">

    <!-- Custom Theme Style -->
    <link href="/css/custom.min.css" rel="stylesheet">
</head>
<body class="nav-md">
    <form id="form1" runat="server">
        <div class="container body">
            <div class="main_container">
                <!-- page content -->
                <div class="col-md-12">
                    <div class="col-middle">
                        <div class="text-center text-center">
                            <h1 class="error-number">500</h1>
                            <h2>Internal Server Error</h2>
                            <p>
                                Rastreamos esses erros automaticamente, mas se o problema persistir, entre em contato conosco. Enquanto isso, tente atualizar. <a href="#">Reportar mesmo assim?</a>
                            </p>

                        </div>
                    </div>
                </div>
                <!-- /page content -->
            </div>
        </div>

        <!-- jQuery -->
        <script src="/bower_components/jquery/dist/jquery.min.js"></script>
        <!-- Bootstrap -->
        <script src="/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
        <!-- FastClick -->
        <script src="/bower_components/fastclick/lib/fastclick.js"></script>
        <!-- NProgress -->
        <script src="/bower_components/nprogress/nprogress.js"></script>

        <!-- Custom Theme Scripts -->
        <script src="/js/custom.min.js"></script>
    </form>
</body>
</html>
