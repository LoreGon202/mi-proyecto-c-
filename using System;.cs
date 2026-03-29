using System;

class Persona
{
    public string nombre;
    public int edad;

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

class Estudiante : Persona
{
    public string carrera;

    public void MostrarCarrera()
    {
        Console.WriteLine("Carrera: " + carrera);
    }
}

// La clase Program se opera desde Program.cs para evitar conflictos de declaración parcial.
// Esta clase contiene solo modelos y lógica complementaria.
