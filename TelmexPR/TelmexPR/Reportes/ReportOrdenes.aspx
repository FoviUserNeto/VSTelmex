<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportOrdenes.aspx.cs" Inherits="TelmexPR.Reportes.ReportOrdenes" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reporte de Ordenes</title>
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
                <td class="auto-style2" colspan="4" style="text-align: center">Reporte de Catalogo de Ordenes</td>
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
    
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="973px" Height="596px">
                        <localreport displayname="Reportes/ReportOrdenes.rdlc" reportembeddedresource="TelmexPR.Reportes.ReportOrdenes.rdlc" reportpath="Reportes/ReportOrdenes.rdlc">
                            <datasources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </datasources>
                        </localreport>
                    </rsweb:ReportViewer>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="TelmexPR.TelmexOrdenDataSetTableAdapters.T_ORDENESTableAdapter" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_ID_ORDEN" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ID_TRABAJADOR" Type="Int32" />
                            <asp:Parameter Name="TT" Type="String" />
                            <asp:Parameter Name="CLAVE" Type="String" />
                            <asp:Parameter Name="RANGO" Type="String" />
                            <asp:Parameter Name="Libreria" Type="String" />
                            <asp:Parameter Name="Area" Type="String" />
                            <asp:Parameter Name="CT" Type="String" />
                            <asp:Parameter Name="CAT" Type="String" />
                            <asp:Parameter Name="OFICINA" Type="String" />
                            <asp:Parameter Name="Folio" Type="Double" />
                            <asp:Parameter Name="Telefono" Type="Double" />
                            <asp:Parameter Name="Tel_Factura" Type="Double" />
                            <asp:Parameter Name="Tipo_OS" Type="String" />
                            <asp:Parameter Name="Clase_Serv" Type="String" />
                            <asp:Parameter Name="Dilacion" Type="Double" />
                            <asp:Parameter Name="Etapa_Actual" Type="String" />
                            <asp:Parameter Name="Deptoid" Type="String" />
                            <asp:Parameter Name="Dilacion_Etapa" Type="Double" />
                            <asp:Parameter Name="Fecha_Entrada" Type="DateTime" />
                            <asp:Parameter Name="Ultima_Etapa" Type="String" />
                            <asp:Parameter Name="Fecha_Ultima_Etapa" Type="DateTime" />
                            <asp:Parameter Name="Distrito" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ID_TRABAJADOR" Type="Int32" />
                            <asp:Parameter Name="TT" Type="String" />
                            <asp:Parameter Name="CLAVE" Type="String" />
                            <asp:Parameter Name="RANGO" Type="String" />
                            <asp:Parameter Name="Libreria" Type="String" />
                            <asp:Parameter Name="Area" Type="String" />
                            <asp:Parameter Name="CT" Type="String" />
                            <asp:Parameter Name="CAT" Type="String" />
                            <asp:Parameter Name="OFICINA" Type="String" />
                            <asp:Parameter Name="Folio" Type="Double" />
                            <asp:Parameter Name="Telefono" Type="Double" />
                            <asp:Parameter Name="Tel_Factura" Type="Double" />
                            <asp:Parameter Name="Tipo_OS" Type="String" />
                            <asp:Parameter Name="Clase_Serv" Type="String" />
                            <asp:Parameter Name="Dilacion" Type="Double" />
                            <asp:Parameter Name="Etapa_Actual" Type="String" />
                            <asp:Parameter Name="Deptoid" Type="String" />
                            <asp:Parameter Name="Dilacion_Etapa" Type="Double" />
                            <asp:Parameter Name="Fecha_Entrada" Type="DateTime" />
                            <asp:Parameter Name="Ultima_Etapa" Type="String" />
                            <asp:Parameter Name="Fecha_Ultima_Etapa" Type="DateTime" />
                            <asp:Parameter Name="Distrito" Type="String" />
                            <asp:Parameter Name="Original_ID_ORDEN" Type="Int32" />
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