using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectMVC.WS.Services
{
    /// <summary>
    /// Metodo que retorna la tabla de posiciones de los equipos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Parcial : System.Web.Services.WebService
    {
        /// <summary>
        /// CONSULTA PARCIAL
        /// </summary>
        /// <returns>RETORNA TABLA DE POSICIONES</returns>
        [WebMethod]
        public List<Logica.Models.DB.Parcial> GetParcials()
        {
            var listParcial = new List<Logica.Models.DB.Parcial>();

            Logica.Services.Parcial Parcials = new Logica.Services.Parcial();
            listParcial = Parcials.GetParcials();

            return listParcial;
        }
    }
}
