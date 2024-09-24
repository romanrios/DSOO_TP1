using System;
using System.Collections.Generic;

namespace DSOO_TP1
{
    internal class Socio
    {
        public int idSocio { get; set; }
        public string nombre { get; set; }
        public List<string> actividadesInscriptas { get; set; }

        public Socio(int id, string nombre)
        {
            this.idSocio = id;
            this.nombre = nombre;
            this.actividadesInscriptas = new List<string>();
        }

        public void sumarActividadASocio(string nombreActividad)
        {
            actividadesInscriptas.Add(nombreActividad);
        }
    }
}