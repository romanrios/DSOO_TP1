using System;
using System.Collections.Generic;

public class Socio
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
        if (actividades.Count < 3)
        {
            actividades.Add(nombreActividad);
        }
    }
}

public class ClubDeportivo
{
    private List<Socio> socios;
    private List<string> actividades;

    public ClubDeportivo()
    {
        socios = new List<Socio>();
        actividades = new List<string> { "Futbol", "Basquet", "Natacion" };
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

    public string inscribirActividad(int idSocio, string nombreActividad)
    {
        if (!actividades.Contains(nombreActividad))
        {
            return "ACTIVIDAD INEXISTENTE";
        }

        Socio socio = socios.Find(s => s.idSocio == idSocio);
        if (socio == null)
        {
            return "SOCIO INEXISTENTE";
        }

        if (socio.actividades.Count >= 3)
        {
            return "TOPE DE ACTIVIDADES ALCANZADO";
        }

        socio.AgregarActividad(nombreActividad);
        return "INSCRIPCIÓN EXITOSA";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ClubDeportivo club = new ClubDeportivo();

        club.altaSocio(1, "Juan Perez");
        club.altaSocio(2, "Maria Lopez");

        Console.WriteLine(club.inscribirActividad(1, "Futbol"));  // INSCRIPCIÓN EXITOSA
        Console.WriteLine(club.inscribirActividad(1, "Natacion"));  // INSCRIPCIÓN EXITOSA
        Console.WriteLine(club.inscribirActividad(1, "Basquet"));  // INSCRIPCIÓN EXITOSA
        Console.WriteLine(club.inscribirActividad(1, "Basquet"));  // TOPE DE ACTIVIDADES ALCANZADO

        Console.WriteLine(club.inscribirActividad(3, "Futbol"));  // SOCIO INEXISTENTE

        Console.WriteLine(club.inscribirActividad(1, "Tenis"));  // ACTIVIDAD INEXISTENTE
    }
}
