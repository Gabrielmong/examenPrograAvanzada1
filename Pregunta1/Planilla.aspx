<%@ Page EnableEventValidation="false"
    AutoEventWireup="true" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="Planilla.aspx.cs" Inherits="Pregunta1.Planilla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="content">
            <asp:HiddenField runat="server" ID="hf_Control" />
            <asp:GridView class="table" DataKeyNames="codigo_empleado" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Panel ID="Panel1" runat="server" Visible="false">
                <div style="display: flex; flex-direction: column; align-items: center;">
                    <div style="display: flex; flex-direction: row; align-items: center;">
                    <div style="display: flex; flex-direction: column; align-items: center;">
                        <p>Nombre</p>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        <p>Cooperativa</p>
                        <asp:TextBox ID="txtCooperativa" runat="server"></asp:TextBox>
                        <p>Prestamo</p>
                        <asp:TextBox ID="txtPrestamo" runat="server"></asp:TextBox>
                    </div>
                    <div style="display: flex; flex-direction: column; align-items: center;">
                        <p>Ahorro</p>
                        <asp:TextBox ID="txtAhorro" runat="server"></asp:TextBox>
                        <p>Salario Bruto</p>
                        <asp:TextBox ID="txtSalBruto" runat="server"></asp:TextBox>
                        <p>Salario Neto</p>
                        <asp:TextBox ID="txtSalNeto" runat="server"></asp:TextBox>
                    </div>
                        </div>

                    <p>Total Deducciones</p>
                    <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
                    <div style="margin-top: 1rem;">
                        <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" OnClick="handleClose" />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="handleDelete" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
