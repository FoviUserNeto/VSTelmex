<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurarCopia.aspx.cs" Inherits="TelmexPR.RestaurarCopia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
            color: #FFCC99;
        }
         body {
            background-image:url(image/ImagenFondo.JPG);
        }
        .auto-style3 {
            color: #FFFFFF;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">Restaurar copia de seguridad</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Backup" Visible="False" Width="187px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">Backup Path:&nbsp;
                    <asp:FileUpload ID="FileBackup" runat="server" />
&nbsp;&nbsp;
                    <asp:Button ID="btnRestaurar" runat="server" OnClick="btnRestaurar_Click" Text="Restaurar Backup" Width="185px" />
                &nbsp;&nbsp;&nbsp;&nbsp; Salir:
    
        <asp:ImageButton ID="btnPrincipal" runat="server" ImageUrl="~/image/CERRAR.png" OnClick="btnPrincipal_Click" style="text-align: center" Height="30px" Width="40px" />
    
                </td>
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
        </table>
    
    </div>
    </form>
</body>
</html>
