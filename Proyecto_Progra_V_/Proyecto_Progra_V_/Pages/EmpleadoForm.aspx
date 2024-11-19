<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadoForm.aspx.cs" Inherits="Proyecto_Progra_V_.Pages.EmpleadoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario Empleado</title>
    <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
</head>
<body>

    <div>

        <form id="estudianteForm" runat="server" method="post" action="PersonaForm.aspx">
            <h2>Formulario Empleado</h2>
            <label>Identificacion: </label>
            <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
            <label for="nombre">Nombre:</label>
            <input type="text" id="nombre" name="nombre" class="input" required /><br />
            <label>Apellido:</label>
            <input type="text" id="apellidos" name="apellidos" class="input" required /><br />
            <label>Correo:</label>
            <input type="text" id="correoElectronico" name="correoElectronico" class="input" required /><br />
            <label>Telefono:</label>
            <input type="text" id="telefono" name="telefono" class="input" required /><br />
            <label>Sexo:</label>
            <label>Masculino:</label>
            <input type="checkbox" value="Masculino" class="checkbox" />
            <label>Femenino:</label>
            <input type="checkbox" value="Femenino" class="checkbox" /><br />
            <label>Departamento:</label>
            <input type="number" id="cargo" name="cargo" class="input" required /><br />
            <label>Cargo:</label>
            <input type="text" id="nombre" name="nombre" class="input" required /><br />
            <label>Direccion:</label>
            <input type="text" id="direccion" name="direccion" class="input" required /><br />
            <label>Cantidad Vacacionbes:</label>
            <input type="number" id="cantidadVacaciones" name="cantidadVacaciones" class="input" required /><br />
            <label>Fecha Contratacion:</label>
            <input type="datetime" id="fechaAdicion" name="fechaAdicion" class="input" required /><br />
            <label>Adicionado Por:</label>
            <input type="text" id="adicionadoPor" name="adicionadoPor" class="input" required /><br />
            <label>Fecha Adicion:</label>
            <input type="datetime" id="fechaAdicion" name="fechaAdicion" class="input" required /><br />
            <label>Modificado Por:</label>
            <input type="text" id="modificadoPor" name="modificadoPor" class="input" required /><br />
            <label>Fecha Modificacion:</label>
            <input type="datetime" id="fechaModificacion" name="fechaModificacion" class="input" required /><br />
            <label>Acepta terminos y condiciones:</label>
            <input type="checkbox" value="Aceptar" class="checkbox" /><br />
            <input type="submit" value="Guardar" class="button" />
            <input type="submit" value="Cancelar" class="button" />
        </form>

    </div>

</body>
</html>
