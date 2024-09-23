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

            Console.WriteLine(club.inscribirActividad(1, "Futbol"));
            Console.WriteLine(club.inscribirActividad(1, "Natacion"));
            Console.WriteLine(club.inscribirActividad(1, "Basquet"));
            Console.WriteLine(club.inscribirActividad(1, "Basquet"));

            Console.WriteLine(club.inscribirActividad(3, "Futbol"));
            Console.WriteLine(club.inscribirActividad(1, "Tenis"));
        }
    }
}