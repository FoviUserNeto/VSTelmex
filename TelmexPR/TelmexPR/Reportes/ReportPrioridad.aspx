<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportPrioridad.aspx.cs" Inherits="TelmexPR.Reportes.ReportPrioridad" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reporte de Prioridad</title>
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
                <td class="auto-style2" colspan="4" style="text-align: center">Reporte de Catalogo de Trabajadores</td>
            </tr>
            <tr>
                <td>Salir:&nbsp;
    
        <asp:ImageButton ID="btnPrincipal" runat="server" ImageUrl="~/image/CERRAR.png" OnClick="btnPrincipal_Click" style="text-align: center" Height="30px" Width="40px" />
    
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
    
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="574px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="547px">
                        <localreport displayname="Reportes/ReportPrioridad.rdlc" reportembeddedresource="TelmexPR.Reportes.ReportPrioridad.rdlc" reportpath="Reportes/ReportPrioridad.rdlc">
                            <datasources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </datasources>
                        </localreport>
                    </rsweb:ReportViewer>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="TelmexPR.TelmexOrdenDataSetTableAdapters.T_PRIORIDADTableAdapter" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_ID_PRIORIDAD" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="TIPO_TAREA" Type="String" />
                            <asp:Parameter Name="TIPO_TABLA" Type="String" />
                            <asp:Parameter Name="PRIORIDAD" Type="Double" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="TIPO_TAREA" Type="String" />
                            <asp:Parameter Name="TIPO_TABLA" Type="String" />
                            <asp:Parameter Name="PRIORIDAD" Type="Double" />
                            <asp:Parameter Name="Original_ID_PRIORIDAD" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
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