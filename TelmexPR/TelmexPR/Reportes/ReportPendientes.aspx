<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportPendientes.aspx.cs" Inherits="TelmexPR.Reportes.ReportPendientes" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reporte de Pendientes</title>
     <style type="text/css">
       
         .auto-style1 {
             width: 100%;
         }
         .auto-style2 {
             color: #FFFFFF;
             font-size: x-large;
         }

       body {
             background:#bebebe;
            
         }
         .auto-style3 {
             height: 38px;
         }
     </style>

         
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4" style="text-align: center">Reporte de Catalogo de Pendientes</td>
            </tr>
            <tr>
                <td class="auto-style3">Salir:&nbsp;
    
        <asp:ImageButton ID="btnPrincipal" runat="server" ImageUrl="~/image/CERRAR.png" OnClick="btnPrincipal_Click" style="text-align: center" Height="30px" Width="40px" />
    
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
    
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1065px" Height="694px">
                        <LocalReport DisplayName="Reportes/ReportPendientes.rdlc" ReportPath="Reportes\ReportPendientes.rdlc">
                            <DataSources>
                                <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                            </DataSources>
                        </LocalReport>
                    </rsweb:ReportViewer>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TelmexOrdenConnectionString %>" SelectCommand="SELECT * FROM [T_PENDIENTES]"></asp:SqlDataSource>
                    <br />
    
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>