// Mandato:

// Desarrolla una clase en C# que represente a un Estudiante.
// Esta clase debe contener al menos los siguientes elementos:
// Atributos privados: nombre, matrícula, carrera y calificación promedio.
// Constructor que permita inicializar todos los atributos.
// Métodos públicos:
// MostrarInformacion(): que imprima los datos del estudiante de forma clara.
// EsAprobado(): que retorne true si el promedio es mayor o igual a 70, de lo contrario false.
// Condiciones:
// Usa correctamente los principios básicos de la POO: encapsulamiento y uso de métodos.
// La clase debe estar organizada, con comentarios que expliquen cada parte.
// Al final, en Main, crea al menos dos objetos de tipo Estudiante y llama a sus métodos para demostrar su funcionalidad.
namespace Escuela
{
    class Estudiante
    {
        private string? nombre;
        private int matricula;
        private string? carrera;
        private float promedio;

        // Constructor 
        public Estudiante(string nombre, int matricula, string carrera, float promedio)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.carrera = carrera;
            this.promedio = promedio;
        }

        public void MostrarInformacion()
        {
            System.Console.WriteLine($"Nombre: {nombre} - Matricula: {matricula} - Carrera: {carrera} - Promedio {promedio}");

        }

        public bool EsAprobado()
        {
            if (promedio >= 70.0)
            {
                return true;
            }

            return false;
        
        }


        

    }





}






