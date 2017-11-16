<%@ Page Language="C#" AutoEventWireup="true" CodeFile="desk.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- style del navegador! solo el navegador lateral, no de la estructura de la página-->
    <link href="Content/nav.css" rel="stylesheet" />
     <link href="Content/filternav.css" rel="stylesheet" />
    <title></title>
</head>
<body>

     <nav> <!-- Creamos un navegador-->
        <ul> <!-- añadimos una lista que contendra nuestras opciones de navegación-->

            <!-- agregamos nuestro elemento de lista (li) con un a href (para reenviar a algún lugar tras presionar) y una imagen-->
            <li><a href="desk.aspx"><img src="Content/img/resources/icons/database.png" alt=""/></a></li>
            <li><a href="graficos.aspx"><img src="Content/img/resources/icons/view-2.png" alt=""/></a></li>
            <li><a href="logout.aspx"><img src="Content/img/resources/icons/exit.png" alt=""/></a></li>
        </ul>
    </nav>
    
   <div id="cont-selector">
       <div id="cont-select">
         
          
          <form action="/" method="post" runat="server" cssclass ="of-cont">
        <asp:DropDownList ID="DropDownList1" cssclass="select" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" cssclass="select" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList3"  cssclass="select" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList4" cssclass="select"  runat="server"></asp:DropDownList>
        </form>
         
           <div id="filter-button"><p>Filtrar</p></div>
       
    </div>
   </div>
</body>
</html>
