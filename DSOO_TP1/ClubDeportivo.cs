﻿using System;
using System.Collections.Generic;

namespace DSOO_TP1
{

    internal class ClubDeportivo
    {
        private List<Socio> socios;
        private List<string> actividadesDisponibles;

        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividadesDisponibles = new List<string> { "Futbol", "Basquet", "Natacion" };
        }

        public void altaSocio(int id, string nombre)
        {
            Socio socioExistente = socios.Find(s => s.idSocio == id);
            if (socioExistente == null)
            {
                Socio nuevoSocio = new Socio(id, nombre);
                socios.Add(nuevoSocio);
                Console.WriteLine("Socio registrado exitosamente.");
            }
            else
            {
                Console.WriteLine("El socio ya está registrado.");
            }
        }

        public string inscribirSocioEnActividad(int idSocio, string nombreActividad)
        {
            if (!actividadesDisponibles.Contains(nombreActividad))
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            Socio socio = socios.Find(s => s.idSocio == idSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            if (socio.actividadesInscriptas.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            socio.sumarActividadASocio(nombreActividad);
            return "INSCRIPCIÓN EXITOSA";
        }
    }
}