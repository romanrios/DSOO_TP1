using System;
using System.Collections.Generic;

namespace DSOO_TP1
{
    internal class Socio
    {
        public int idSocio { get; set; }
        public string nombre { get; set; }
        public List<string> actividades { get; set; }

        public Socio(int id, string nombre)
        {
            this.idSocio = id;
            this.nombre = nombre;
            this.actividades = new List<string>();
        }

        public void AgregarActividad(string nombreActividad)
        {
            actividades.Add(nombreActividad);
        }
    }
}