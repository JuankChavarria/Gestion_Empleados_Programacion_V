<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearEmpleado.aspx.cs" Inherits="Proyecto_Progra_V_.Pages.CrearEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Crear Empleado</title>
    <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
</head>
<body>
    <div>
        <form id="crearEmpleadoForm" runat="server">
            <h2>Crear Empleado</h2>
            <label>Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Apellido:</label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Correo:</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Telefono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Sexo:</label>
            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="input">
                <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
            </asp:DropDownList><br />
            <label>Departamento:</label>
            <asp:TextBox ID="txtDepartamentoId" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Cargo:</label>
            <asp:TextBox ID="txtCargo" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Direccion:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Cantidad Vacaciones:</label>
            <asp:TextBox ID="txtCantidadVacaciones" runat="server" CssClass="input" Required="true"></asp:TextBox><br />
            <label>Fecha Contratación:</label>
            <asp:TextBox ID="txtFechaContratacion" runat="server" CssClass="input"></asp:TextBox><br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="button" OnClick="btnGuardar_Click" />
        </form>
    </div> 
</body>
</html>
