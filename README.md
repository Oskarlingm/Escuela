# 🎓 Proyecto: Clase Estudiante en C# (POO)

Este es mi primer proyecto desarrollado con Programación Orientada a Objetos en el lenguaje C#. El objetivo es representar un estudiante mediante una clase bien estructurada que implemente principios básicos como **encapsulamiento** y **uso de métodos**.

## 🧠 Objetivo del Proyecto

- Implementar una clase llamada `Estudiante` con atributos privados y métodos públicos.
- Demostrar el uso de constructores, encapsulamiento, y lógica básica condicional.
- Mostrar cómo crear objetos en C# y utilizar sus métodos para representar comportamientos del mundo real.

---

## 📦 Estructura de la Clase

```csharp
class Estudiante
{
    // Atributos privados
    private string? nombre;
    private int matricula;
    private string? carrera;
    private float promedio;

    // Constructor para inicializar los atributos
    public Estudiante(string nombre, int matricula, string carrera, float promedio)

    // Método que muestra la información del estudiante
    public void MostrarInformacion()

    // Método que verifica si el estudiante está aprobado
    public bool EsAprobado()
}
