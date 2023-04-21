<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SistemaECU911.WebForm1" %>

<!Doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>ECU 911 | Sistema Médico</title>
    <link rel="shortcut icon" href="resources/assets/images/favicon.ico" />
    <link rel="stylesheet" href="resources/assets/css/backend-plugin.min.css">
    <link rel="stylesheet" href="resources/assets/css/backend.css?v=1.0.0">
    <link rel="stylesheet" href="resources/assets/vendor/line-awesome/dist/line-awesome/css/line-awesome.min.css">
    <link rel="stylesheet" href="resources/assets/vendor/remixicon/fonts/remixicon.css">
    <link rel="stylesheet" href="resources/assets/vendor/tui-calendar/tui-calendar/dist/tui-calendar.css">
    <link rel="stylesheet" href="resources/assets/vendor/tui-calendar/tui-date-picker/dist/tui-date-picker.css">
    <link rel="stylesheet" href="resources/assets/vendor/tui-calendar/tui-time-picker/dist/tui-time-picker.css">
    <!-- Recursos Extras Personales -->
    <link rel="stylesheet" href="resources/assets/vendor/font-awesome-pro-v6-6/css/all.min.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Fin Recursos Extras Personales -->
</head>
<body class="  ">
    <!-- loader Start -->
    <div id="loading">
        <div id="loading-center">
        </div>
    </div>
    <!-- loader END -->



    <div class="wrapper">

        <div class="iq-sidebar  sidebar-default ">
            <div class="iq-sidebar-logo d-flex align-items-center">
                <a href="../backend/index.html" class="header-logo">
                    <img src="Template/Template Principal/images/ECU911.png" alt="logo" style="width: 10rem; height: 4.688rem">
                </a>
                <div class="iq-menu-bt-sidebar ml-0">
                    <i class="las la-bars wrapper-menu"></i>
                </div>
            </div>
            <div class="data-scrollbar" data-scroll="1">
                <nav class="iq-sidebar-menu">
                    <ul id="iq-sidebar-toggle" class="iq-menu">
                        <li class="active">
                            <a href="../backend/index.html" class="svg-icon">
                                <svg class="svg-icon" width="25" height="25" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                    <path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path>
                                    <polyline points="9 22 9 12 15 12 15 22"></polyline>
                                </svg>
                                <span class="ml-4">Inicio</span>
                            </a>
                        </li>
                        <li class="active">
                            <a href="../backend/index.html" class="svg-icon">
                                <svg class="svg-icon" width="25" height="25" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                    <path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"></path>
                                    <polyline points="9 22 9 12 15 12 15 22"></polyline>
                                </svg>
                                <span class="ml-4">Ficha Medica</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="#otherpage" class="collapsed" data-toggle="collapse" aria-expanded="false">
                                <svg class="svg-icon" width="25" height="25" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                    <path d="M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"></path>
                                </svg>
                                <span class="ml-4">other page</span>
                                <i class="las la-angle-right iq-arrow-right arrow-active"></i>
                                <i class="las la-angle-down iq-arrow-right arrow-hover"></i>
                            </a>
                            <ul id="otherpage" class="iq-submenu collapse" data-parent="#iq-sidebar-toggle">
                                <li class="">
                                    <a class="nav-link" href="../backend/timeline.html">
                                        <svg class="svg-icon" id="p-dash016" width="20" height="20" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                            <circle cx="12" cy="12" r="10"></circle><polyline points="12 6 12 12 16 14"></polyline>
                                        </svg>
                                        <span class="ml-4">Timeline</span>
                                    </a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </nav>
                <div id="sidebar-bottom" class="position-relative sidebar-bottom">
                    <div class="card border-none mb-0 shadow-none">
                        <div class="card-body p-0">
                            <div class="sidebarbottom-content">
                                <h5 class="mb-3">Task Performed</h5>
                                <div id="circle-progress-6" class="sidebar-circle circle-progress circle-progress-primary mb-4" data-min-value="0" data-max-value="100" data-value="55" data-type="percent"></div>
                                <div class="custom-control custom-radio mb-1">
                                    <input type="radio" id="customRadio6" name="customRadio-1" class="custom-control-input" checked="">
                                    <label class="custom-control-label" for="customRadio6">Performed task</label>
                                </div>
                                <div class="custom-control custom-radio">
                                    <input type="radio" id="customRadio7" name="customRadio-1" class="custom-control-input">
                                    <label class="custom-control-label" for="customRadio7">Incomplete Task</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="pt-5 pb-2"></div>
            </div>
        </div>
        <div class="iq-top-navbar">
            <div class="iq-navbar-custom">
                <nav class="navbar navbar-expand-lg navbar-light p-0">
                    <div class="iq-navbar-logo d-flex align-items-center justify-content-between">
                        <i class="ri-menu-line wrapper-menu"></i>
                        <a href="../backend/index.html" class="header-logo">
                            <img src="../../resources/assets/images/LogoECU.png" alt="logo" style="height: 4.063rem; width: 9.375rem; padding-top: 0.438rem">
                        </a>
                    </div>
                    <div class="navbar-breadcrumb">
                        <h5>Dashboard</h5>
                    </div>
                    <div class="d-flex align-items-center">
                        <button class="navbar-toggler" type="button" data-toggle="collapse"
                            data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                            aria-label="Toggle navigation">
                            <i class="ri-menu-3-line"></i>
                        </button>
                        <div class="collapse navbar-collapse" id="navbarSupportedContent">
                            <ul class="navbar-nav ml-auto navbar-list align-items-center">
                                <li class="nav-item nav-icon nav-item-icon dropdown">
                                    <a href="#" onclick="javascript:toggleFullScreen()">
                                        <i class="fa-regular fa-expand fa-lg"></i>
                                        <span class="bg-primary "></span>
                                    </a>
                                </li>
                                <li>
                                    <div class="iq-search-bar device-search">
                                        <form action="#" class="searchbox">
                                            <a class="search-link" href="#"><i class="ri-search-line"></i></a>
                                            <input type="text" class="text search-input" placeholder="Search here...">
                                        </form>
                                    </div>
                                </li>
                                <li class="nav-item nav-icon search-content">
                                    <a href="#" class="search-toggle rounded" id="dropdownSearch" data-toggle="dropdown"
                                        aria-haspopup="true" aria-expanded="false">
                                        <i class="ri-search-line"></i>
                                    </a>
                                    <div class="iq-search-bar iq-sub-dropdown dropdown-menu" aria-labelledby="dropdownSearch">
                                        <form action="#" class="searchbox p-2">
                                            <div class="form-group mb-0 position-relative">
                                                <input type="text" class="text search-input font-size-12"
                                                    placeholder="type here to search...">
                                                <a href="#" class="search-link"><i class="las la-search"></i></a>
                                            </div>
                                        </form>
                                    </div>
                                </li>
                                <li class="nav-item nav-icon dropdown caption-content">
                                    <a href="#" class="search-toggle dropdown-toggle  d-flex align-items-center" id="dropdownMenuButton4"
                                        data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        <img src="../../resources/assets/images/User.png" class="img-fluid rounded-circle" alt="user">
                                        <div class="caption ml-3">
                                            <h6 class="mb-0 line-height">Savannah Nguyen<i class="las la-angle-down ml-2"></i></h6>
                                        </div>
                                    </a>
                                    <ul class="dropdown-menu dropdown-menu-right border-none" aria-labelledby="dropdownMenuButton">
                                        <li class="dropdown-item d-flex svg-icon">
                                            <svg class="svg-icon mr-0 text-primary" id="h-01-p" width="20" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                                                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M5.121 17.804A13.937 13.937 0 0112 16c2.5 0 4.847.655 6.879 1.804M15 10a3 3 0 11-6 0 3 3 0 016 0zm6 2a9 9 0 11-18 0 9 9 0 0118 0z" />
                                            </svg>
                                            <a href="../app/user-profile.html">My Profile</a>
                                        </li>
                                        <li class="dropdown-item  d-flex svg-icon border-top">
                                            <svg class="svg-icon mr-0 text-primary" id="h-05-p" width="20" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                                                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M17 16l4-4m0 0l-4-4m4 4H7m6 4v1a3 3 0 01-3 3H6a3 3 0 01-3-3V7a3 3 0 013-3h4a3 3 0 013 3v1" />
                                            </svg>
                                            <a href="../backend/auth-sign-in.html">Logout</a>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
            </div>
        </div>
        <div class="content-page">
            <div class="container-fluid">
                <asp:ContentPlaceHolder ID="Message" runat="server"></asp:ContentPlaceHolder>
                <asp:ContentPlaceHolder ID="Content" runat="server"></asp:ContentPlaceHolder>
            </div>
        </div>
    </div>



    <footer class="iq-footer">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg text-right">
                    <span class="mr-1 text-muted text-center text-sm-right d-block d-sm-inline-block">Copyright © 2023.
                    </span>
                    <a href="https://www.ecu911.gob.ec/">Servicio Integrado de Seguridad ECU 911</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="resources/assets/js/backend-bundle.min.js"></script>
    <script src="resources/assets/js/table-treeview.js"></script>
    <script src="resources/assets/js/customizer.js"></script>
    <script async src="resources/assets/js/chart-custom.js"></script>
    <script async src="resources/assets/js/slider.js"></script>
    <script src="resources/assets/js/app.js"></script>
    <script src="resources/assets/vendor/moment.min.js"></script>
    <script src="resources/assets/js/script.js"></script>
</body>
</html>
