using System;
using System.Collections.Generic;

namespace DSOO_TP1
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            ClubDeportivo club = new ClubDeportivo();

            club.altaSocio(1, "Juan Perez");
            club.altaSocio(2, "Maria Lopez");

            Console.WriteLine(club.inscribirSocioEnActividad(1, "Futbol"));
            Console.WriteLine(club.inscribirSocioEnActividad(1, "Natacion"));
            Console.WriteLine(club.inscribirSocioEnActividad(1, "Basquet"));
            Console.WriteLine(club.inscribirSocioEnActividad(1, "Basquet"));

            Console.WriteLine(club.inscribirSocioEnActividad(3, "Futbol"));
            Console.WriteLine(club.inscribirSocioEnActividad(1, "Tenis"));
        }
    }
}