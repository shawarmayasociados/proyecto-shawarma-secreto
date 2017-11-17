using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string Connect = ConfigurationManager.ConnectionStrings["connectuserinfo"].ConnectionString;
        using (SqlConnection con = new SqlConnection(Connect))
            if (Session["user"] != null)
            {
                // lista seleccón dropdown 1
                string Bancos = "select nombre from ignacio.banco";
                SqlCommand cmdBancos = new SqlCommand(Bancos, con);
                con.Open();
                SqlDataAdapter datosbanco = new SqlDataAdapter(cmdBancos);
                DataTable tablabanco = new DataTable();
                datosbanco.Fill(tablabanco);
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "nombre";
                DropDownList1.DataSource = tablabanco;
                DropDownList1.DataBind();

                DropDownList1.Items.Insert(0, "Bancos");
                // lista seleccón dropdown 2
                string[] valores = new string[5];
                valores[0] = "500000";
                valores[1] = "1999999";
                valores[2] = "20000000";
                valores[3] = "4999999";
                valores[4] = "5000000";

                int i = 0;
                
                while (true)
                {
                    if (i <= 1)
                    {
                        DropDownList2.Items.Add(valores[2 * i] + "-" + valores[2 * i + 1]);
                    }

                    else
                    {
                        DropDownList2.Items.Add(valores[4] + " "+ "o" +" " +"Más");
                        break;
                    }
                    i++;
                }
                DropDownList2.Items.Insert(0, "Monto");

                // lista seleccón dropdown 3
                string[] cuotas = new string[10];
                cuotas[0] = "12";
                cuotas[1] = "19";
                cuotas[2] = "20";
                cuotas[3] = "29";
                cuotas[4] = "30";
                cuotas[5] = "39";
                cuotas[6] = "40";
                cuotas[7] = "49";
                cuotas[8] = "50";
                cuotas[9] = "60";

                int b = 0;

                while (true)
                {
                    if (b <= 4)
                    {
                        DropDownList3.Items.Add(cuotas[2 * b] + "-" + cuotas[2 * b + 1]);
                    }

                    else
                    {
                        
                        break;
                    }
                    b++;
                }

                DropDownList3.Items.Insert(0, "Cuotas");

                string[] tasa = new string[6];
                tasa[0] = "1.0";
                tasa[1] = "1.4";
                tasa[2] = "1.5";
                tasa[3] = "1.9";
                tasa[4] = "2.0";
                tasa[5] = "2.5";

                int c = 0;

                while (true)
                {
                    if (c <= 2)
                    {
                        DropDownList4.Items.Add(tasa[2 * c] + "-" + tasa[2 * c + 1]);
                    }

                    else
                    {

                        break;
                    }
                    c++;
                }
                DropDownList4.Items.Insert(0, "Tasa");
                
            }
            else
        {
            Response.Redirect("~/login.aspx");
        }


    }

    protected void logout(object sender,EventArgs e)
    {
        
        Response.Redirect("~/logout.aspx");
    }



    protected void Filtrar_Click(object sender, EventArgs e)
    {

    }
    string consulta = "select* from ignacio.simulacion" ;







    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string consultabanco = "where idbanco in (select idbanco from ignacio.banco where nombre = @bancoseleccionado)";  
         
    }
}