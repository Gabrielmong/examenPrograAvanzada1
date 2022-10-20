<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresarDeducciones.aspx.cs" Inherits="Pregunta1.IngresarDeducciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Deducciones del empleado</h1>
        <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; height: 90vh">
            <div style="display: flex; flex-direction: row; align-items: center; justify-content: center">
            <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; margin-right: 3rem">
                <asp:HiddenField runat="server" ID="hf_Control" />
                <div class ="Jumbotron">
                </div>
                <h3>Datos del empleado</h3>
                <p>Codigo</p>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <p>ID de Empleado</p>
                <asp:TextBox ID="txtIdEmpleado" runat="server"></asp:TextBox>
                <p>Cooperativa</p>
                <asp:TextBox ID="txtCoop" runat="server"></asp:TextBox>
                <p>Prestamo</p>
                <asp:TextBox ID="txtPrestamo" runat="server"></asp:TextBox>
                <p>Ahorro</p>
                <asp:TextBox ID="txtAhorro" runat="server"></asp:TextBox>
            <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Incluir" OnClick="handleSave" style="margin-top: 1rem;"/>
            </div>
            </div>
        </div>
        </div>
</asp:Content>
