<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CopiaSeguridad.aspx.cs" Inherits="TelmexPR.CopiaSeguridad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;

        }
        body {
            background-image:url(image/ImagenFondo.JPG);
        }


        .auto-style2 {
            color: #FFFFFF;
        }
        .auto-style3 {
            color: #FFFF99;
            font-size: x-large;
            text-align: center;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="3"><strong>Generar una copia de seguridad</strong></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">Generar Backup del Sistema:&nbsp;&nbsp;&nbsp; <asp:Button ID="btnBackup" runat="server" OnClick="btnBackup_Click" OnClientClick="return confirm('Esta seguro que desea realizar un backup del sistema?')" Text="Generador de Copia" Width="182px" />
    
                &nbsp;&nbsp;&nbsp;&nbsp; Salir:
    
        <asp:ImageButton ID="btnPrincipal" runat="server" ImageUrl="~/image/CERRAR.png" OnClick="btnPrincipal_Click" style="text-align: center" Height="30px" Width="40px" />
    
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
