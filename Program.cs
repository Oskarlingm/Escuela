using System.Runtime.InteropServices;

namespace Escuela
{
    class Program
    {

        public static void Main()
        {
            Estudiante estudiante1 = new Estudiante("Gary", 20221018, "Software", 100.0f);
            Estudiante estudiante2 = new Estudiante("Oskarr", 20089323, "Software", 100.00f);
            

            estudiante1.MostrarInformacion();
            estudiante2.MostrarInformacion();


            System.Console.WriteLine($"Estudiante a pasado? {estudiante1.EsAprobado()}");
            System.Console.WriteLine($"Estudiante a pasado? {estudiante2.EsAprobado()}");


        }
        







    }



}