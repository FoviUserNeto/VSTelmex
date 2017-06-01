<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trabajador.aspx.cs" Inherits="TelmexPR.Trabajador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Usuarios</title>
    <link rel="stylesheet" href="estilos-Usu.css" />
    <link href="Estilos/bootstrap.css" rel="stylesheet" />    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style11 {
            width: 171px;
        }
        .auto-style13 {
            width: 350px;
        }
        .modalBackground{
            background-color:black;
            filter: alpha(opacity=90);
            opacity:0.8;
            z-index:10000;
        }
        .auto-style16 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="Script1" runat="server"></asp:ScriptManager>
       <div class="contenedor">
       <article>
    
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="text-align: center">LISTADO DE TRABAJADORES</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtBuscar" runat="server" style="text-align: right" Width="150px" Visible="False"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnBuscar" runat="server" Height="20px" ImageUrl="~/image/16 (Search).ico" Width="30px" OnClick="btnBuscar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnNuevo" runat="server" Height="20px" ImageUrl="~/image/1.png" OnClick="btnNuevo_Click" Width="30px" />
                    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="btnNuevo" PopupControlID="PnGuardar" CancelControlID="btnCancelar" BackgroundCssClass="modalBackground"> </ajaxToolkit:ModalPopupExtender>  
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnImprimir" runat="server" Height="20px" ImageUrl="~/image/impresora.ico" Width="30px" OnClick="btnImprimir_Click" />
                   
                     &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnSalir" runat="server" Height="20px" ImageUrl="~/image/CERRAR.png" Width="30px" OnClick="btnSalir_Click" /> 
                                   </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Panel ID="PnGrid" runat="server">
                        <asp:GridView ID="gvUsuarios" runat="server" CellPadding="4" ForeColor="#333333" Width="100%" OnSelectedIndexChanged="gvOcurrencias_SelectedIndexChanged" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderStyle="None" BorderWidth="1px" DataKeyNames="ID_USUARIO">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="ID_USUARIO" HeaderText="Clave de Usuario" Visible="False" />
                                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre de Usuario" HtmlEncode="False" />
                                <asp:BoundField DataField="CARGO" HeaderText="Cargo" HtmlEncode="False" />
                                <asp:BoundField DataField="USUARIO" HeaderText="Usuario" HtmlEncode="False" />
                                <asp:BoundField DataField="CONTRASEÑA" HeaderText="Contraseña" Visible="False" HtmlEncode="False" />
                                <asp:TemplateField HeaderText="Editar">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnEditar" runat="server" Height="20px" ImageUrl="~/image/modif.png" OnClick="btnEditar_Click" Width="30px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Eliminar">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnEliminar" runat="server" Height="20px" ImageUrl="~/image/16 (Delete).ico" Width="30px" OnClick="btnEliminar_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Panel ID="PnGuardar" runat="server">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style16" colspan="3">
                                    <asp:Label ID="Label1" runat="server" Text="Registro"></asp:Label>
                                    &nbsp;de Usuarios</td>
                            </tr>
                            <tr>
                                <td class="auto-style16" colspan="3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    Expediente:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtExpediente" runat="server" style="margin-bottom: 1px" Width="250px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    Nombre:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtNombre" runat="server" style="margin-bottom: 1px" Width="250px"></asp:TextBox>
                                </td>
                                <td>&nbsp; &nbsp; &nbsp; &nbsp; </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    Apelllidos:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtApellidos" runat="server" style="margin-bottom: 1px" Width="250px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    Sexo:</td>
                                <td class="auto-style13">
                                    <asp:DropDownList ID="ddwSexo" runat="server" Width="57px">
                                        <asp:ListItem>M</asp:ListItem>
                                        <asp:ListItem>F</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    Fecha de Nacimiento:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtFecha" runat="server" style="margin-bottom: 1px" Width="250px" TextMode="Password">Vuelva escribir la contraseña</asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Dirección:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtDireccion" runat="server" style="margin-bottom: 1px" TextMode="Password" Width="250px">Vuelva escribir la contraseña</asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Teléfono:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtTelefono" runat="server" style="margin-bottom: 1px" TextMode="Password" Width="250px">Vuelva escribir la contraseña</asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Email:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtEmail" runat="server" style="margin-bottom: 1px" TextMode="Password" Width="250px">Vuelva escribir la contraseña</asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style13">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style13">
                                    <asp:ImageButton ID="btnGuardar" runat="server" Height="30px" ImageUrl="~/image/save.png" OnClick="btnGuardar_Click1" Width="40px" />
                                    &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="btnCancelar" runat="server" Height="30px" ImageUrl="~/image/cancelar.png" Width="40px" />
                                    &nbsp;&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                        </table>
                        <br />
                    </asp:Panel>
                </td>
            </tr>
            </table>
    </article>
    </div>

    </form>
</body>
</html>

