using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;


 public class DataBase
{
    public List<Simulacion> Obtenerlista()
    {
        List<Simulacion> ListaSimulacion = new List<Simulacion>();
        using (SqlConnection cn = new SqlConnection("Data Source=184.168.194.75;Integrated Security=False;User ID=ignacio ; Password=123456;Connect Timeout=15;Encrypt=False;Packet Size=4096"))
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("select sim.tasa, sim.cuota, sim.monto, bco.nombre,clt.nombre, sim.fecha, sim.cae"+
                                               "from ignacio.simulacion as sim"+
                                                "inner join ignacio.banco as bco"+
                                                   "on sim.idBanco = bco.idBanco"+
                                                    "inner join ignacio.cliente as clt"+
                                                     "on sim.idCliente = clt.idCliente", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {

                
                Simulacion a = new Simulacion();
                a.tasaSimulacion = double.Parse(dr["tasa"].ToString());
                a.cuotaSimulacion = int.Parse(dr["cuota"].ToString());
                a.montoSimulacion = int.Parse(dr["monto"].ToString());
                a.nombreBanco = dr["nombre"].ToString();
                a.nombreCliente = dr["nombre1"].ToString();
                a.fechaSimulacion = dr["fecha"].ToString();
                a.montoTotal = int.Parse(dr["cae"].ToString());

                ListaSimulacion.Add(a);

            }
            
        }
        return ListaSimulacion;
    }
}


////// query maestra select sim.tasa, sim.cuota, sim.monto, bco.nombre,clt.nombre, sim.fecha, sim.cae
/*from ignacio.simulacion as sim
inner join ignacio.banco as bco
on sim.idBanco = bco.idBanco
inner join ignacio.cliente as clt
on sim.idCliente= clt.idCliente where
sim.monto<@montomayor or @montomayor is null
and sim.monto> @montomenor or @montomenor is null
and sim.cuota<@cuotamayor or @cuotamayor is null
and sim.cuota> @cuotamenor or @cuotamenor is null
and sim.tasa<@tasamayor  or @tasamayor is null
and sim.tasa> @tasamenor or @tasamenor is null
and bco.nombre= @nombrebanco or @nombrebanco is null*/