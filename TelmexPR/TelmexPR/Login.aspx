<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TelmexPR.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ORDENES</title>
    <style type="text/css">
       .auto-style1 {
            width: 100%;
        }
        .auto-style2 { 
            width: 33px;
        }
        .auto-style3 { 
            width: 28px;
        }
        .auto-style4 {
            width: 114px;
        }
                
        .auto-style1 { /*cuadro login*/
            background-color:#808080; 
            background: rgba(20,20,20, 0.85); 
            border-radius: 0.5em; 
            -webkit-border-radius: 0.5em; 
            box-shadow: rgba(0,0,0,0.6) 0px 5px 10px; 
            border-radius:8px;
            width:280px; 
            height:250px;
            margin-top:100px; 
            margin-left: auto; 
            margin-right: auto; 
            margin-bottom:auto;
        }
        /*Slider de fondo*/
        *{
            margin:0px;
            padding:0px;
        }
        .contenido{
            width:100%;
            height:100%;
        }
        .backgroundslider{
            width:100%;
            height:100%;
            position:fixed;
            top:0px;
            left:0px;
            z-index:-1;
        }
        .backgroundslider li{
            position:absolute;
            width:100%;
            height:100%;
            background-position:center center;
            background-repeat: no-repeat;
            background-size:cover;
            opacity:0;
            animation:imagenes 30s linear infinite;
            -moz-animation:imagenes 30s linear infinite;
            -ms-animation:imagenes 30s linear infinite;
            -o-animation:imagenes 30s linear infinite;
            -webkit-animation:imagenes 30s linear infinite;
        }
        .backgroundslider li:nth-child(1){
            background-image:url(image/paisaje1.JPG); 
        } 
        .backgroundslider li:nth-child(2){
            background-image:url(image/paisaje2.JPG);
            animation-delay:6s;
            -moz-animation-delay:6s;
            -ms-animation-delay:6s;
            -o-animation-delay:6s;
            -webkit-animation-delay:6s; 
        }
        .backgroundslider li:nth-child(3){
            background-image:url(image/paisaje3.PNG);
            animation-delay:12s;
            -moz-animation-delay:12s;
            -ms-animation-delay:12s;
            -o-animation-delay:12s;
            -webkit-animation-delay:12s;
        } /*
        .backgroundslider li:nth-child(4){
            background-image:url(image/Imagen4.jpg);
            animation-delay:18s;
            -moz-animation-delay:18s;
            -ms-animation-delay:18s;
            -o-animation-delay:18s;
            -webkit-animation-delay:18s;
        }  */
    
        @keyframes imagenes{
            0% {opacity:0; animation-timing-function:ease-in;}
            10% {opacity:1; animation-timing-function:ease-out;}
            25% {opacity:1; transform:scale(1);}
            50% {opacity:0; transform:scale(2) rotate(20deg);}
            100% {opacity:0;}
        }
        @-moz-keyframes imagenes{
            0% {opacity:0; animation-timing-function:ease-in;}
            10% {opacity:1; animation-timing-function:ease-out;}
            25% {opacity:1; transform:scale(1);}
            50% {opacity:0; transform:scale(2) rotate(20deg);}
            100% {opacity:0;}
        }
        @-o-keyframes imagenes{
            0% {opacity:0; animation-timing-function:ease-in;}
            10% {opacity:1; animation-timing-function:ease-out;}
            25% {opacity:1; transform:scale(1);}
            50% {opacity:0; transform:scale(2) rotate(20deg);}
            100% {opacity:0;}
        }
        @-ms-keyframes imagenes{
            0% {opacity:0; animation-timing-function:ease-in;}
            10% {opacity:1; animation-timing-function:ease-out;}
            25% {opacity:1; transform:scale(1);}
            50% {opacity:0; transform:scale(2) rotate(20deg);}
            100% {opacity:0;}
        }
      
        /*texto de bienvenidos*/
        .testbox{
            background:#808080;
            border-radius:8px; /*border:1px solid black;*/
            padding: 15px;
            margin: 15px 5px;
            width: 400px;
            -webkit-transition:width 3s, color 2s;
            color:white;
        }
        .testbox:hover{
            width:545px;
            color: red; /*white*/
        }
       #texto{
            text-align:center;
            font: bold 20px Tahoma;
            width:100%;  
        }
       
        
       .auto-style5 {
            color: #FFFFFF;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenido">
        <ul class="backgroundslider">
            <li></li>
            <li></li>
            <li></li>
            <li></li>
       </ul>
       </div>
    
    <center>
        <div class="testbox" style="background: rgba(20,20,20, 0.65); border-radius: 0.5em; -webkit-border-radius: 0.5em; box-shadow: rgba(0,0,0,0.6) 0px 5px 10px;">
            <p id="texto">BIENVENIDOS AL SISTEMA DE AUTOMATIZACIÓN DE ORDENES</p>
        </div>
    </center>

    <div>
        <!--cuadro de login-->
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="4">
                    <asp:Image ID="Image1" runat="server" Height="171px" ImageUrl="~/image/logooo.jpg" Width="200px" />
                </td>
                <td class="auto-style3">
                    <asp:Image ID="Image5" runat="server" Height="40px" ImageUrl="~/image/Administrador.png" Width="40px" />
                </td>
                <td class="auto-style4" style="font-family:Britannic">
                    <asp:Label ID="Label1" runat="server" Text="PERSONAL" ForeColor="White"></asp:Label>
                </td> 
                <td class="auto-style5">
                    <asp:DropDownList ID="ddwUsuario" runat="server" Height="30px" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="ddwUsuario_SelectedIndexChanged1"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/image/Administrador1.png" Width="40px" />
                </td>
                <td class="auto-style4" style="font-family:Britannic;">
                    <asp:Label ID="lblUsuario" runat="server" Text="USUARIO" ForeColor="White"></asp:Label>
                </td> 
                <td class="auto-style5">
                    <asp:TextBox ID="txtUsuario" runat="server" Width="181px" Font-Bold="False" Font-Overline="False" Height="25px"></asp:TextBox>
                </td> 
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="Image4" runat="server" Height="40px" ImageUrl="~/image/CandadoCerrado.png" Width="40px" />
                </td>
                <td class="auto-style4" style="font-family:Britannic;">
                    <asp:Label ID="lblContraseña" runat="server" Text="CONTRASEÑA" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtContraseña" runat="server" Width="181px" TextMode="Password" Height="25px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnIngresar" runat="server" BackColor="#009933" BorderColor="#009933" Height="30px" Text="INGRESAR" Width="85px" OnClick="btnIngresar_Click1" />
                   &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" BackColor="#009933" BorderColor="#009933" Height="30px" Text="CANCELAR" Width="85px" />
                    <br />
                    <span class="auto-style5">¿No dispones de una cuenta?
                    </span>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Page_Load" PostBackUrl="~/Usuario.aspx">Registrate ahora</asp:LinkButton>
                     <br /><br />
                    <asp:CheckBox ID="ckRecordar" runat="server" Text="     Recordar Contraseña" ForeColor="White" style="text-align: left" /><br /> 
        </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>

    </form>
</body>
</html>

