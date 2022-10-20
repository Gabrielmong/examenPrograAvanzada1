<%@ Page Title="Ingresar Empleado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresarEmpleado.aspx.cs" Inherits="Pregunta1.IngresarEmpleado" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ingresar Empleado</h1>
        <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; height: 90vh">
            <div style="display: flex; flex-direction: row; align-items: center; justify-content: center">
            <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; margin-right: 3rem">
                <asp:HiddenField runat="server" ID="hf_Control" />
                <div class="Jumbotron">
                </div>
                <h3>Datos del empleado</h3>
                <p>Codigo</p>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <p>Nombre</p>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <p>Horas Laboradas</p>
                <asp:TextBox ID="txtHoras" runat="server"></asp:TextBox>
                <p>Salario Hora</p>
                <asp:TextBox ID="txtSalHora" runat="server"></asp:TextBox>
            <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Incluir" OnClick="handleSave" style="margin-top: 1rem;"/>
            </div>
            </div>
        </div>
        </div>
        
</asp:Content>
