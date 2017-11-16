using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;



public class Program
    {
        public static List<string[]> RecuperarDatosFiltrados()
        {

            // conexion con base de datos
            using (SqlConnection cn = new SqlConnection("Data Source = 184.168.194.75; Integrated Security = False; User ID = ignacio; Password = 123456; Connect Timeout = 15; Encrypt = False; Packet Size = 4096"))
            {
                /*string consulta = "select * from ignacio.simulacion where monto<@montomayor and monto>@montomenor and cuota<@cuotamayor and cuota>@cuotamenor and tasa< @tasamayor and tasa> @tasamenor and idbanco in (select idbanco from banco where Nombre = @nombrebanco) ";*/
                /*string consulta= "select * from ignacio.simulacion where monto < 1500000 and monto> 500000 and cuota< 48 and cuota> 12 and tasa< 1.5 and tasa> 1.0and idbanco in (select idbanco from ignacio.banco where nombre = 'Banco Paris')";*/
                string consulta = "select* from ignacio.simulacion";
                List<String[]> ListaSimulaciones = new List<string[]>();
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                //se ingresan los parametros de atributos
                /*  cmd.Parameters.AddWithValue("@montomayor", Console.ReadLine());
              cmd.Parameters.AddWithValue("@montomenor", Console.ReadLine());
              cmd.Parameters.AddWithValue("@cuotamayor", Console.ReadLine() );
              cmd.Parameters.AddWithValue("@cuotamenor", Console.ReadLine());
              cmd.Parameters.AddWithValue("@tasamayor", Console.ReadLine());
              cmd.Parameters.AddWithValue("@tasamenor", Console.ReadLine());
              cmd.Parameters.AddWithValue("@nombrebanco", Console.ReadLine());*/


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] respuesta = new string[7];
                    for (int i = 0; i < respuesta.Length; i++)
                    {
                        respuesta[i] = reader[i].ToString();
                    }
                    ListaSimulaciones.Add(respuesta);
                }

                return ListaSimulaciones;
            }




        }


        public static void EnviarLista(List<string[]> Lista)
        {
            foreach (string[] elemento in Lista)
            {
                for (int i = 0; i < elemento.Length; i++)
                {
                    Console.Write(elemento[i] + " // ");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            EnviarLista(RecuperarDatosFiltrados());

            Console.ReadLine();
        }
    }
