<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SistemaECU911.Template.Views.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Inicio</title>
    <link rel="stylesheet" href="../Template Principal/vendors/iconfonts/font-awesome/css/all.min.css" />
    <link rel="stylesheet" href="../Template Principal/vendors/css/vendor.bundle.base.css">
    <link rel="stylesheet" href="../Template Principal/vendors/css/vendor.bundle.addons.css">
    <link rel="stylesheet" href="../Template Principal/css/style.css">
    <link rel="shortcut icon" href="http://www.urbanui.com/" />
</head>
<body>
    <div class="container-scroller">
        <nav class="navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row default-layout-navbar">
            <div class="text-center navbar-brand-wrapper d-flex align-items-center justify-content-center">
                <a class="navbar-brand brand-logo" href="index-2.html">
                    <img src="../Template Principal/images/ic1.png" alt="logo" /></a>
                <a class="navbar-brand brand-logo-mini" href="index-2.html">
                    <img src="../Template Principal/images/ic2.jpg" alt="logo" /></a>
            </div>
            <div class="navbar-menu-wrapper d-flex align-items-stretch">
                <button class="navbar-toggler navbar-toggler align-self-center" type="button" data-toggle="minimize">
                    <span class="fas fa-bars"></span>
                </button>
                <ul class="navbar-nav">
                    <li class="nav-item nav-search d-none d-md-flex">
                        <div class="nav-link">
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">
                                        <i class="fas fa-search"></i>
                                    </span>
                                </div>
                                <input type="text" class="form-control" placeholder="Buscar..." aria-label="Search">
                            </div>
                        </div>
                    </li>
                </ul>
                <ul class="navbar-nav navbar-nav-right">
                    <li class="nav-item d-none d-lg-flex">
                        <a class="nav-link" href="#">
                            <span class="btn btn-primary">+ Crear Nuevo </span>
                        </a>
                    </li>
                    <li class="nav-item nav-profile dropdown">
                        <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown" id="profileDropdown">
                            <img src="../Template Principal/images/faces/face5.jpg" alt="profile" />
                        </a>
                        <div class="dropdown-menu dropdown-menu-right navbar-dropdown" aria-labelledby="profileDropdown">
                            <a class="dropdown-item">
                                <i class="fas fa-cog text-primary"></i>
                                Configuración
                            </a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item">
                                <i class="fas fa-power-off text-primary"></i>
                                Cerrar Sesión
                            </a>
                        </div>
                    </li>
                </ul>
            </div>
        </nav>
        <!-- partial -->
        <div class="container-fluid page-body-wrapper">
            <!-- partial:partials/_settings-panel.html -->
            <div class="theme-setting-wrapper">
                <div id="settings-trigger"><i class="fas fa-fill-drip"></i></div>
                <div id="theme-settings" class="settings-panel">
                    <i class="settings-close fa fa-times"></i>
                    <p class="settings-heading">SIDEBAR SKINS</p>
                    <div class="sidebar-bg-options selected" id="sidebar-light-theme">
                        <div class="img-ss rounded-circle bg-light border mr-3"></div>
                        Light
                    </div>
                    <div class="sidebar-bg-options" id="sidebar-dark-theme">
                        <div class="img-ss rounded-circle bg-dark border mr-3"></div>
                        Dark
                    </div>
                    <p class="settings-heading mt-2">HEADER SKINS</p>
                    <div class="color-tiles mx-0 px-4">
                        <div class="tiles primary"></div>
                        <div class="tiles success"></div>
                        <div class="tiles warning"></div>
                        <div class="tiles danger"></div>
                        <div class="tiles info"></div>
                        <div class="tiles dark"></div>
                        <div class="tiles default"></div>
                    </div>
                </div>
            </div>
            <div id="right-sidebar" class="settings-panel">
                <i class="settings-close fa fa-times"></i>
                <ul class="nav nav-tabs" id="setting-panel" role="tablist">
                    <li class="nav-item">
                        <a class="nav-link active" id="todo-tab" data-toggle="tab" href="#todo-section" role="tab" aria-controls="todo-section" aria-expanded="true">TO DO LIST</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="chats-tab" data-toggle="tab" href="#chats-section" role="tab" aria-controls="chats-section">CHATS</a>
                    </li>
                </ul>
            </div>
            <!-- partial -->
            <!-- partial:partials/_sidebar.html -->
            <nav class="sidebar sidebar-offcanvas" id="sidebar">
                <ul class="nav">
                    <li class="nav-item nav-profile">
                        <div class="nav-link">
                            <div class="profile-image">
                                <img src="../Template Principal/images/faces/face5.jpg" alt="image" />
                            </div>
                            <div class="profile-name">
                                <p class="name">
                                    Bienvenido Jane
               
                                </p>
                                <p class="designation">
                                    Administrador
                                </p>
                            </div>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="WebForm1.aspx">
                            <i class="fa fa-home menu-icon"></i>
                            <span class="menu-title">Inicio</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">
                            <i class="fas fa-ambulance menu-icon"></i>
                            <span class="menu-title">Pacientes</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" data-toggle="collapse" href="#ui-advanced" aria-expanded="false" aria-controls="ui-advanced">
                            <i class="fas fa-clipboard-list menu-icon"></i>
                            <span class="menu-title">Historial</span>
                            <i class="menu-arrow"></i>
                        </a>
                        <div class="collapse" id="ui-advanced">
                            <ul class="nav flex-column sub-menu">
                                <li class="nav-item"><a class="nav-link" href="pages/ui-features/dragula.html">Dragula</a></li>
                                <li class="nav-item"><a class="nav-link" href="pages/ui-features/clipboard.html">Clipboard</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" data-toggle="collapse" href="#form-elements" aria-expanded="false" aria-controls="form-elements">
                            <i class="fab fa-wpforms menu-icon"></i>
                            <span class="menu-title">Historial 2.0</span>
                            <i class="menu-arrow"></i>
                        </a>
                        <div class="collapse" id="form-elements">
                            <ul class="nav flex-column sub-menu">
                                <li class="nav-item"><a class="nav-link" href="pages/forms/basic_elements.html">Basic Elements</a></li>
                                <li class="nav-item"><a class="nav-link" href="pages/forms/advanced_elements.html">Advanced Elements</a></li>
                            </ul>
                        </div>
                    </li>
                </ul>
            </nav>
            <!-- partial -->
            <div class="main-panel">
                <div class="content-wrapper">
                    <div class="page-header">
                        <h3 class="page-title">Inicio
                        </h3>
                    </div>
                    <div class="row grid-margin">
                        <div class="col-12">
                            <div class="card card-statistics">
                                <div class="card-body">
                                    <div class="d-flex flex-column flex-md-row align-items-center justify-content-between">
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fa fa-user mr-2"></i>
                                                New users
                       
                                            </p>
                                            <h2>54000</h2>
                                            <label class="badge badge-outline-success badge-pill">2.7% increase</label>
                                        </div>
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fas fa-hourglass-half mr-2"></i>
                                                Avg Time
                       
                                            </p>
                                            <h2>123.50</h2>
                                            <label class="badge badge-outline-danger badge-pill">30% decrease</label>
                                        </div>
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fas fa-cloud-download-alt mr-2"></i>
                                                Downloads
                       
                                            </p>
                                            <h2>3500</h2>
                                            <label class="badge badge-outline-success badge-pill">12% increase</label>
                                        </div>
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fas fa-check-circle mr-2"></i>
                                                Update
                       
                                            </p>
                                            <h2>7500</h2>
                                            <label class="badge badge-outline-success badge-pill">57% increase</label>
                                        </div>
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fas fa-chart-line mr-2"></i>
                                                Sales
                       
                                            </p>
                                            <h2>9000</h2>
                                            <label class="badge badge-outline-success badge-pill">10% increase</label>
                                        </div>
                                        <div class="statistics-item">
                                            <p>
                                                <i class="icon-sm fas fa-circle-notch mr-2"></i>
                                                Pending
                       
                                            </p>
                                            <h2>7500</h2>
                                            <label class="badge badge-outline-danger badge-pill">16% decrease</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>                   
                    <div class="row">
                        <div class="col-md-8 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">
                                    <h4 class="card-title">
                                        <i class="fas fa-table"></i>
                                        Sales Data
                                    </h4>
                                    <div class="table-responsive">
                                        <table class="table">
                                            <thead>
                                                <tr>
                                                    <th>Customer</th>
                                                    <th>Item code</th>
                                                    <th>Orders</th>
                                                    <th>Status</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td class="font-weight-bold">Clifford Wilson
                                                    </td>
                                                    <td class="text-muted">PT613
                                                    </td>
                                                    <td>350
                                                    </td>
                                                    <td>
                                                        <label class="badge badge-success badge-pill">Dispatched</label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="font-weight-bold">Mary Payne
                                                    </td>
                                                    <td class="text-muted">ST456
                                                    </td>
                                                    <td>520
                                                    </td>
                                                    <td>
                                                        <label class="badge badge-warning badge-pill">Processing</label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="font-weight-bold">Adelaide Blake
                                                    </td>
                                                    <td class="text-muted">CS789
                                                    </td>
                                                    <td>830
                                                    </td>
                                                    <td>
                                                        <label class="badge badge-danger badge-pill">Failed</label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="font-weight-bold">Adeline King
                                                    </td>
                                                    <td class="text-muted">LP908
                                                    </td>
                                                    <td>579
                                                    </td>
                                                    <td>
                                                        <label class="badge badge-primary badge-pill">Delivered</label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="font-weight-bold">Bertie Robbins
                                                    </td>
                                                    <td class="text-muted">HF675
                                                    </td>
                                                    <td>790
                                                    </td>
                                                    <td>
                                                        <label class="badge badge-info badge-pill">On Hold</label>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">
                                    <h4 class="card-title">
                                        <i class="fas fa-calendar-alt"></i>
                                        Calendario
                                    </h4>
                                    <div id="inline-datepicker-example" class="datepicker"></div>
                                </div>
                            </div>
                        </div>
                    </div>                   
                    <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-body">
                                    <div class="d-md-flex justify-content-between align-items-center">
                                        <div class="d-flex align-items-center mb-3 mb-md-0">
                                            <button class="btn btn-social-icon btn-facebook btn-rounded">
                                                <i class="fab fa-facebook-f"></i>
                                            </button>
                                            <div class="ml-4">
                                                <h5 class="mb-0">Facebook</h5>
                                                <p class="mb-0">813 friends</p>
                                            </div>
                                        </div>
                                        <div class="d-flex align-items-center mb-3 mb-md-0">
                                            <button class="btn btn-social-icon btn-twitter btn-rounded">
                                                <i class="fab fa-twitter"></i>
                                            </button>
                                            <div class="ml-4">
                                                <h5 class="mb-0">Twitter</h5>
                                                <p class="mb-0">9000 followers</p>
                                            </div>
                                        </div>
                                        <div class="d-flex align-items-center mb-3 mb-md-0">
                                            <button class="btn btn-social-icon btn-google btn-rounded">
                                                <i class="fab fa-google-plus-g"></i>
                                            </button>
                                            <div class="ml-4">
                                                <h5 class="mb-0">Google plus</h5>
                                                <p class="mb-0">780 friends</p>
                                            </div>
                                        </div>
                                        <div class="d-flex align-items-center">
                                            <button class="btn btn-social-icon btn-linkedin btn-rounded">
                                                <i class="fab fa-linkedin-in"></i>
                                            </button>
                                            <div class="ml-4">
                                                <h5 class="mb-0">Linkedin</h5>
                                                <p class="mb-0">1090 connections</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <footer class="footer">
                    <div class="d-sm-flex justify-content-center justify-content-sm-between">
                        <span class="text-muted text-center text-sm-left d-block d-sm-inline-block">Copyright © 2018. Todos los derechos reservados</span>
                    </div>
                </footer>
            </div>
        </div>
    </div>
    <script src="../Template Principal/vendors/js/vendor.bundle.base.js"></script>
    <script src="../Template Principal/vendors/js/vendor.bundle.addons.js"></script>
    <script src="../Template Principal/js/off-canvas.js"></script>
    <script src="../Template Principal/js/hoverable-collapse.js"></script>
    <script src="../Template Principal/js/misc.js"></script>
    <script src="../Template Principal/js/settings.js"></script>
    <script src="../Template Principal/js/todolist.js"></script>
    <script src="../Template Principal/js/dashboard.js"></script>
</body>


</html>

