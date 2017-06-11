<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TelmexPR.Inicio" %>

<!DOCTYPE html>

<html lang="en">
	<head>
		<link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css'>
		<meta charset="utf-8">
		<title>Ordenes</title>
		<link href="style.css" media="screen" rel="stylesheet" type="text/css" />
		<link href="iconic.css" media="screen" rel="stylesheet" type="text/css" />
		<script src="prefix-free.js"></script>
	</head>

<body>
	<div class="wrap">
	
	<nav>
		<ul class="menu">
			<li><a href="#"><span class="iconic home"></span> Inicio</a></li>
			<li><a href="Ordenes.aspx"><span class="iconic plus-alt"></span> Ordenes</a>
				<ul>
					<li><a href="Produccion.aspx">Producción</a></li>
					<li><a href="Pendientes.aspx">Pendientes</a></li>
                    <li><a href="Prioridad.aspx">Prioridad</a></li>
				</ul>
			</li>
			<li><a href="#"><span class="iconic magnifying-glass"></span> Reportes</a>
				<ul>
					<li><a href="Reportes/ReportProduccion.aspx">Reporte de Producción</a></li>
					<li><a href="Reportes/ReportPendientes.aspx">Reporte de Pendientes</a></li>
					<li><a href="Reportes/ReportTrabajador.aspx">Reporte de Empleados</a></li>
                    <li><a href="Reportes/ReportOrdenes.aspx">Reporte de Ordenes</a></li>
                    <li><a href="Reportes/ReportPrioridad.aspx">Reporte de Prioridad</a></li>
					<!--<li><a href="#">Copyrighting</a></li>-->
				</ul>
			</li>
			<li><a href="#"><span class="iconic map-pin"></span> Configuración</a>
				<ul>
					<li><a href="Trabajador.aspx">Trabajador</a></li>
					<li><a href="Usuario.aspx">Usuarios</a></li>
                    <li><a href="CopiaSeguriddad.aspx">Generar una copia de seguridad</a></li>
                    <li><a href="RestaurarCopia">Restaurar copia de seguridad</a></li>
				
				</ul>
			</li>
			<li><a href="#"><span class="iconic mail"></span> Utilidades</a>
				<ul>
					<li><a href="http://www.Google.com/" target="_blank">Navegador</a></li>
					<li><a href="#">Calculadora</a></li>
                    <li><a href="#">Bloc de Notas</a></li>
					<li><a href="#">Teclado</a></li>
                    
				</ul>
			</li>
            <li><a href="#"><span class="iconic mail"></span> Accesos Rápidos</a>
				<ul>
					<li><a href="Login.aspx">Cerrar Sesión</a></li>
					<li><a href="http://www.Facebook.com/" target="_blank">Facebook</a></li>
                    <li><a href="http://www.Hotmail.com/" target="_blank">Email</a></li>
					<li><a href="http://www.Youtube.com/" target="_blank">Youtube</a></li>
                    <li><a href="http://www.Twitter.com/" target="_blank">Twitter</a></li>
				</ul>
			</li>
		</ul>
		<div class="clearfix"></div>
	</nav>
	</div>
</body>

</html>