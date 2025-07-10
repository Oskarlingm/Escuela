using System.Runtime.InteropServices;

namespace Escuela
{
    class Program
    {

        public static void Main()
        {
            Estudiante estudiante1 = new Estudiante("Gary", 20221018, "Software", 100.0f);
            Estudiante estudiante2 = new Estudiante("Oskarr", 20089323, "Software", 100.00f);
            Estudiante estudiante3 = new Estudiante("Ossas", 20245634, "Redes", 60.0f);
            Estudiante estudiante4 = new Estudiante("Marcos", 2022342, "Mecatronica", 50.0f);
            Estudiante estudiante5 = new Estudiante("Kaory", 2022503, "Multimedia", 100.0f);

            estudiante1.MostrarInformacion();
            estudiante3.MostrarInformacion();


            System.Console.WriteLine($"Estudiante a pasado? {estudiante1.EsAprobado()}"); 
            System.Console.WriteLine($"Estudiante a pasado? {estudiante3.EsAprobado()}");


        }







    }



}