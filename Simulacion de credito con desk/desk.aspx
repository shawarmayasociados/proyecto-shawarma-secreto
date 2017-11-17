<%@ Page Language="C#" AutoEventWireup="true" CodeFile="desk.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- style del navegador! solo el navegador lateral, no de la estructura de la página-->
    <link href="Content/nav.css" rel="stylesheet" />
     <link href="Content/filternav.css" rel="stylesheet" />
    <link href="Content/font.css" rel="stylesheet" />
    <title></title>
</head>
<body>

     <form id="form1" runat="server">

     <nav> <!-- Creamos un navegador-->
        <ul> <!-- añadimos una lista que contendra nuestras opciones de navegación-->

            <!-- agregamos nuestro elemento de lista (li) con un a href (para reenviar a algún lugar tras presionar) y una imagen-->
            <li><a href="desk.aspx"><img src="Content/img/resources/icons/database.png" alt=""/></a></li>
            <li><a href="graficos.aspx"><img src="Content/img/resources/icons/stats.png" alt=""/></a></li>
            <li><a href="registros.aspx"><img src="Content/img/resources/icons/view-2.png" alt=""/></a></li>
            <li><a href="logout.aspx"><img src="Content/img/resources/icons/exit.png" alt=""/></a></li>
        </ul>
    </nav>
    
   <div id="cont-selector">
       <div id="cont-select">
         

        <asp:DropDownList ID="DropDownList1" cssclass="select" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" cssclass="select" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList3"  cssclass="select" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList4" cssclass="select"  runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>

            <asp:Button ID="Filtrar" runat="server" cssclass="filter-button" Text="Filtrar" OnClick="Filtrar_Click" />

     </div>

          

       
    
   </div>
         <asp:GridView ID="GridView2" runat="server" cssclass="grilla" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField HeaderText="IdSimulación" />
                 <asp:BoundField HeaderText="Tasa" />
                 <asp:BoundField HeaderText="Cuota" />
                 <asp:BoundField HeaderText="Monto" />
                 <asp:BoundField HeaderText="Banco" />
                 <asp:BoundField HeaderText="Cliente" />
                 <asp:BoundField HeaderText="Fecha" />
                 <asp:BoundField HeaderText="Monto Final" />
             </Columns>
         </asp:GridView>
     </form>
</body>
</html>
