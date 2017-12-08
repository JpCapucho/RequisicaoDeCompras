<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RequisicaoAX.Login" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Login | Monitor </title>

    <!-- Bootstrap -->
    <link href="~/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="~/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="~/bower_components/nprogress/nprogress.css" rel="stylesheet">
    <!-- Animate.css -->
    <link href="~/bower_components/animate.css/animate.min.css" rel="stylesheet">
    <!-- Custom Theme Style -->
    <link href="~/css/custom.css" rel="stylesheet">

</head>
<body class="login">
    <form id="form1" runat="server">
        <div>
            <a class="hiddenanchor" id="signup"></a>
            <a class="hiddenanchor" id="signin"></a>

            <div class="login_wrapper">
                <div class="animate form login_form">
                    <section class="login_content">
                        <div class="form">
                            <h1>Login Form</h1>
                            <div>
                                <asp:TextBox ID="tbUsuario" runat="server" type="text" class="form-control" placeholder="Usuario" />
                            </div>
                            <div>
                                <asp:TextBox ID="tbSenha" runat="server" type="password" class="form-control" placeholder="Senha" />
                            </div>
                            <div>
                                <br />
                                <asp:Button ID="btnLogin" runat="server" Text="Log in" CssClass="btn btn-default submit" OnClick="btnLogin_Click" />
                                <a class="reset_pass" href="#">Esqueceu sua senha?</a>
                            </div>

                            <div class="clearfix"></div>

                            <div class="separator">
                                <p class="change_link">
                                    Novo no site?
                                <a href="#signup" class="to_register">Criar Conta </a>
                                </p>

                                <div class="clearfix"></div>
                                <br />

                                <div>
                                    <h1><i class="fa fa-money"></i>  RequisicaoAX </h1>
                                    <p>&copy;<%: DateTime.Now.Year %> All Rights Reserved. Gentelella Alela! is a Bootstrap 3 template. Privacy and Terms</p>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>

                <div id="register" class="animate form registration_form">
                    <section class="login_content">
                        <div class="form">
                            <h1>Criar Conta</h1>
                            <div>
                                <input type="text" class="form-control" placeholder="Usuario"  />
                            </div>
                            <div>
                                <input type="email" class="form-control" placeholder="Email"  />
                            </div>
                            <div>
                                <input type="password" class="form-control" placeholder="Senha"  />
                            </div>
                            <div>
                                <a class="btn btn-default submit" href="~/home/index">Enviar</a>
                            </div>

                            <div class="clearfix"></div>

                            <div class="separator">
                                <p class="change_link">
                                    Já é um membro ?
                                <a href="#signin" class="to_register">Log in </a>
                                </p>

                                <div class="clearfix"></div>
                                <br />

                                <div>
                                    <h1><i class="fa fa-money"></i>RequisicaoAX </h1>
                                    <p>&copy;<%: DateTime.Now.Year %> All Rights Reserved. Gentelella Alela! is a Bootstrap 3 template. Privacy and Terms</p>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
