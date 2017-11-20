using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Simulacion
/// </summary>
public class Simulacion
{
 
    public double tasaSimulacion { get; set; }
    public int cuotaSimulacion { get; set; }
    public int montoSimulacion { get; set; }
    public string nombreBanco { get; set; }
    public string nombreCliente { get; set; }
    public string fechaSimulacion { get; set; }
    public int montoTotal { get; set; }

    public Simulacion()
    {
        this.idSimulacion = 0;
        this.tasaSimulacion = 0;
        this.cuotaSimulacion = 0;
        this.montoSimulacion = 0;
        this.idBanco = 0;
        this.idCliente = 0;
        this.fechaSimulacion = "";
        this.montoTotal = 0;
    }
    public Simulacion(int idsimulacion,double tasa, int cuota, int monto, int idbanco, int idcliente, string fecha, int montototal)
    {
        this.idSimulacion = idsimulacion;
        this.tasaSimulacion = tasa;
        this.cuotaSimulacion = cuota;
        this.montoSimulacion = monto;
        this.idBanco = idbanco;
        this.idCliente = idcliente;
        this.fechaSimulacion = fecha;
        this.montoTotal = montototal;
    }
}