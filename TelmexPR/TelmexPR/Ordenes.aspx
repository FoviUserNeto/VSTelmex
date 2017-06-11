<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ordenes.aspx.cs" Inherits="TelmexPR.Ordenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ordenes</title>
    <link rel="stylesheet" href="estilos-Usu.css">
    <link href="Estilos/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style3 {
            font-size: large;
            color: #33CCFF;
            text-align: center;
        }
        .auto-style5 {
        }
        .modalBackground{
            background-color:black;
            filter: alpha(opacity=90);
            opacity:0.8;
            z-index:10000;
        }
        .auto-style7 {
            width: 235px;
        }
        .auto-style8 {
            width: 235px;
            text-align: center;
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
                <td>
&nbsp;<span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></td>
            </tr>
            <tr>
                <td align="center" class="auto-style3">IMPORTAR LISTADO DE ORDENES</td>
            </tr>
            <tr>
                <td align="center" class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="auto-style3">
                    <asp:Panel ID="Panel1" runat="server" style="text-align: left">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">
                                    Orden:</td>
                                <td colspan="2">
                                    <asp:FileUpload ID="FilePlantilla" runat="server" style="margin-left: 0px" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:ImageButton ID="Importar" runat="server" Height="30px" ImageUrl="~/image/Importar.jpeg" OnClick="Importar_Click" Width="40px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Buscar:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="txtBuscar" runat="server" style="margin-bottom: 1px" Width="150px"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:ImageButton ID="btnBuscar" runat="server" Height="20px" ImageUrl="~/image/16 (Search).ico" OnClick="btnBuscar_Click" Width="30px" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:ImageButton ID="btnNuevo" runat="server" Height="20px" ImageUrl="~/image/1.png" OnClick="btnNuevo_Click" Width="30px" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="modalBackground" CancelControlID="btnCancelar" PopupControlID="PnGuardar" TargetControlID="btnNuevo">
                                    </ajaxToolkit:ModalPopupExtender>
                                    <asp:ImageButton ID="btnImprimir" runat="server" Height="20px" ImageUrl="~/image/impresora.ico" Width="30px" OnClick="btnImprimir_Click" />
                                    &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                    
                                    
                                    <asp:ImageButton ID="btnSalir" runat="server" Height="20px" ImageUrl="~/image/CERRAR.png" OnClick="btnSalir_Click" Width="30px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5" colspan="3">
                                    <asp:Panel ID="PnGrid" runat="server">
                                        <asp:GridView ID="gvOrdenes" runat="server" CellPadding="4" Font-Size="X-Small" ForeColor="#333333">
                                            <AlternatingRowStyle BackColor="White" />
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
                                <td colspan="3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5" colspan="3">
                                    <asp:Panel ID="PnGuardar" runat="server" style="display: none;">
                                        <table class="auto-style1">
                                            <tr>
                                                <td colspan="3">Plantilla</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style7">&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Clave:</td>
                                                <td>
                                                    <asp:TextBox ID="txtClave" runat="server" Width="101px"></asp:TextBox>
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Nombre:</td>
                                                <td>
                                                    <asp:TextBox ID="txtNombre" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Sexo:</td>
                                                <td>
                                                    <asp:DropDownList ID="ddwSexo" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Función:</td>
                                                <td>
                                                    <asp:TextBox ID="txtFuncion" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Organización:</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Direccion Funcional:</td>
                                                <td>
                                                    <asp:TextBox ID="txtFuncional" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Email:</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox17" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Sub_Personal:</td>
                                                <td>
                                                    <asp:TextBox ID="txtPersonal" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Curp:</td>
                                                <td>
                                                    <asp:TextBox ID="txtCurp" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">División</td>
                                                <td>
                                                    <asp:TextBox ID="txtDivision" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Edad:</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox18" runat="server" Height="16px" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Dirección Regional</td>
                                                <td>
                                                    <asp:TextBox ID="txtRegional" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">Formación:</td>
                                                <td>
                                                    <asp:TextBox ID="txtFormacion" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Proyecto:</td>
                                                <td>
                                                    <asp:TextBox ID="txtProyecto" runat="server" Width="250px"></asp:TextBox>
                                                </td>
                                                <td class="text-center">CECO:</td>
                                                <td>
                                                    <asp:TextBox ID="txtCECO" runat="server" Height="16px" Width="90px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">Tipo de Personal:</td>
                                                <td>
                                                    <asp:DropDownList ID="ddwPersonal" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style8">&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style7">&nbsp;</td>
                                                <td colspan="3">
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Button ID="btnGuardar0" runat="server" Text="Guardar" Width="125px" />
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="125px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style7">&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            </table>
    </article>
    </div>
    </form>
</body>
</html>