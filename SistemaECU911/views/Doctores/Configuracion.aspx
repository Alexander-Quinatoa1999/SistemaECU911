<%@ Page Title="" Language="C#" MasterPageFile="~/views/Doctores/Medico.Master" AutoEventWireup="true" CodeBehind="Configuracion.aspx.cs" Inherits="SistemaECU911.views.Doctores.Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Configuración Usuario | Sistema Médico
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Message" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <%--<asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick"></asp:Timer>--%>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Content" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-body p-0">
                            <div class="iq-edit-list usr-edit">
                                <ul class="iq-edit-profile d-flex nav nav-pills">
                                    <li class="col-md-6 p-0">
                                        <a class="nav-link active" data-toggle="pill" href="#personal-information">Información Personal
                              </a>
                                    </li>
                                    <li class="col-md-6 p-0">
                                        <a class="nav-link" data-toggle="pill" href="#chang-pwd">Cambio de Contraseña
                              </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="iq-edit-list-data">
                        <div class="tab-content">
                            <div class="tab-pane fade active show" id="personal-information" role="tabpanel">
                                <div class="card">
                                    <div class="card-body">
                                        <form>
                                            <div class="form-group row align-items-center">
                                                <div class="col-md-12">
                                                    <div class="profile-img-edit">
                                                        <div class="crm-profile-img-edit">
                                                            <img class="crm-profile-pic rounded-circle avatar-100" src="../../resources/assets/images/User.png" alt="profile-pic">
                                                            <div class="crm-p-image bg-primary">
                                                                <i class="las la-pen upload-button"></i>
                                                                <input class="file-upload" type="file" accept="image/*">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=" row align-items-center">
                                                <div class="form-group col-sm-6">
                                                    <label for="fname">Primer Nombre:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_priNombre" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="lname">Segundo Nombre:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_segNombre" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="fname">Primer Apellido:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_priApellido" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="lname">Segundo Apellido:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_segApellido" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="uname">Nombre de Usuario:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_user" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="cname">Correo Institucional:</label>
                                                    <asp:TextBox CssClass="form-control" ID="TextBox1" TextMode="Email" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label class="d-block">Genero:</label>
                                                    <div class="row">
                                                        <div class="col-2">
                                                            <asp:CheckBox ID="ckb_Hombre" Enabled="true" runat="server" />
                                                            <label>Hombre</label>
                                                        </div>
                                                        <div class="col-2">
                                                            <asp:CheckBox ID="ckb_Mujer" Enabled="true" runat="server" />
                                                            <label>Mujer</label>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label for="dob">Fecha de Nacimiento:</label>
                                                    <asp:TextBox CssClass="form-control" ID="txt_fechNacimiento" TextMode="Date" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label>Marital Status:</label>
                                                    <select class="form-control" id="exampleFormControlSelect1">
                                                        <option selected="">Single</option>
                                                        <option>Married</option>
                                                        <option>Widowed</option>
                                                        <option>Divorced</option>
                                                        <option>Separated </option>
                                                    </select>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label>Age:</label>
                                                    <select class="form-control" id="exampleFormControlSelect2">
                                                        <option>12-18</option>
                                                        <option>19-32</option>
                                                        <option selected="">33-45</option>
                                                        <option>46-62</option>
                                                        <option>63 > </option>
                                                    </select>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label>Country:</label>
                                                    <select class="form-control" id="exampleFormControlSelect3">
                                                        <option>Caneda</option>
                                                        <option>Noida</option>
                                                        <option selected="">USA</option>
                                                        <option>India</option>
                                                        <option>Africa</option>
                                                    </select>
                                                </div>
                                                <div class="form-group col-sm-6">
                                                    <label>State:</label>
                                                    <select class="form-control" id="exampleFormControlSelect4">
                                                        <option>California</option>
                                                        <option>Florida</option>
                                                        <option selected="">Georgia</option>
                                                        <option>Connecticut</option>
                                                        <option>Louisiana</option>
                                                    </select>
                                                </div>
                                                <div class="form-group col-sm-12">
                                                    <label>Dirección:</label>
                                                    <textarea class="form-control" name="address" rows="5" style="line-height: 22px;">
                                       37 Cardinal Lane
                                       Petersburg, VA 23803
                                       United States of America
                                       Zip Code: 85001
                                       </textarea>
                                                </div>
                                            </div>
                                            <button type="submit" class="btn btn-primary mr-2">Submit</button>
                                            <button type="reset" class="btn iq-bg-danger">Cancel</button>
                                        </form>
                                    </div>
                                </div>
                            </div>
                            <div class="tab-pane fade" id="chang-pwd" role="tabpanel">
                                <div class="card">
                                    <div class="card-header d-flex justify-content-between">
                                        <div class="iq-header-title">
                                            <h4 class="card-title">Change Password</h4>
                                        </div>
                                    </div>
                                    <div class="card-body">
                                        <form>
                                            <div class="form-group">
                                                <label for="cpass">Current Password:</label>
                                                <a href="javascripe:void();" class="float-right">Forgot Password</a>
                                                <input type="Password" class="form-control" id="cpass" value="">
                                            </div>
                                            <div class="form-group">
                                                <label for="npass">New Password:</label>
                                                <input type="Password" class="form-control" id="npass" value="">
                                            </div>
                                            <div class="form-group">
                                                <label for="vpass">Verify Password:</label>
                                                <input type="Password" class="form-control" id="vpass" value="">
                                            </div>
                                            <button type="submit" class="btn btn-primary mr-2">Submit</button>
                                            <button type="reset" class="btn iq-bg-danger">Cancel</button>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
