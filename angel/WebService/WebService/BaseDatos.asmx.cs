﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebService
{
    /// <summary>
    /// Descripción breve de BaseDatos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BaseDatos : System.Web.Services.WebService
    {

       

        [WebMethod]
        public DataSet GetData()
        {
            //  SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=ANGEL; Initial Catalog=Supermercado; Integrated Security=True;";

            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Venta", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

       

        }
}
