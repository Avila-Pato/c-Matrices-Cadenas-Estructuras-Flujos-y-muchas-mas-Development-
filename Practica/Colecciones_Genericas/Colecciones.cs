// 3 tipos de colecciones 
// Genericas
// no genericas
// Concurrentes

// se concentrara el curso en las genericas, ya que son las mas usadas.

//  colecciones genericas
// 1- dictionary
// 2- list
// 3- queue
// 4- stack
// 5- sorted list


 
namespace Colecciones
{
    class ColeccionesOLD
    {
    public static void MainOLD(string[] args)
    {
        object numeroEntero = 5; // esto es una caja, se guarda el valor en un objeto
        object cadena = "Hola"; // esto es una caja, se guarda el valor en un objeto
        object floatFlotante = 3.14f; // esto es una caja, se guarda el valor en un objeto

        object[] numero = new object[2]; // esto es una caja, se guarda el valor en un objeto
        numero[0] = 5; // esto es una caja, se guarda el valor en un objeto
        numero[1] = "Pato";


        object numero1 = 5; // esto es una caja, se guarda el valor en un objeto
        object numero2 = 10; // esto es una caja, se guarda el valor en un objeto
        object resultado = (int)numero1 + (int)numero2; // esto es una caja, se guarda el valor en un objeto
        Console.WriteLine("El resultado es: " + resultado);

        int numGrande = 500;
        byte numPequeno = (byte)numGrande; // esto es una caja, se guarda el valor en un objeto

    }
    }
}