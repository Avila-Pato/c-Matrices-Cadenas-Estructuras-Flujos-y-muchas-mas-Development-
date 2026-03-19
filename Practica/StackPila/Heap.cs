using System;

class Persona
{
    public string Nombre;
}

class Heap
{
    static void Main(string[] args)
    {
        Persona p = new Persona(); // objeto en el heap
        p.Nombre = "Juan";

        Console.WriteLine(p.Nombre);

        Console.ReadKey();
    }
}