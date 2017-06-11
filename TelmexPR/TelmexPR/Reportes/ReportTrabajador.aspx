<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportTrabajador.aspx.cs" Inherits="TelmexPR.Reportes.ReportTrabajador" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reporte de Trabajadores</title>
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
    
                    <rsweb:ReportViewer ID="ReportTrabahador" runat="server" Width="599px" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="641px">
                        <localreport displayname="Reportes/ReportTrabajador.rdlc" reportembeddedresource="TelmexPR.Reportes.ReportTrabajador.rdlc" reportpath="Reportes/ReportTrabajador.rdlc">
                            <datasources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetPrincipal" />
                            </datasources>
                        </localreport>
                    </rsweb:ReportViewer>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="TelmexPR.TelmexOrdenDataSetTableAdapters.T_TRABAJADORTableAdapter" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="Original_ID_TRABAJADOR" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ID_USUARIO" Type="Int32" />
                            <asp:Parameter Name="EXPEDIENTE" Type="String" />
                            <asp:Parameter Name="NOMBRE" Type="String" />
                            <asp:Parameter Name="APELLIDOS" Type="String" />
                            <asp:Parameter Name="SEXO" Type="String" />
                            <asp:Parameter Name="FECHANAC" Type="DateTime" />
                            <asp:Parameter Name="DIRECCION" Type="String" />
                            <asp:Parameter Name="TELEFONO" Type="String" />
                            <asp:Parameter Name="EMAIL" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ID_USUARIO" Type="Int32" />
                            <asp:Parameter Name="EXPEDIENTE" Type="String" />
                            <asp:Parameter Name="NOMBRE" Type="String" />
                            <asp:Parameter Name="APELLIDOS" Type="String" />
                            <asp:Parameter Name="SEXO" Type="String" />
                            <asp:Parameter Name="FECHANAC" Type="DateTime" />
                            <asp:Parameter Name="DIRECCION" Type="String" />
                            <asp:Parameter Name="TELEFONO" Type="String" />
                            <asp:Parameter Name="EMAIL" Type="String" />
                            <asp:Parameter Name="Original_ID_TRABAJADOR" Type="Int32" />
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