using System.ComponentModel.DataAnnotations;

class Dictionary_Ejercicio
{
    public static void Main(string[] args)
    {
        //Varaibles necesarias

        int opcion;
        string nombre, buscarContacto, confirmar;
        long numero = 0;
        // Instanciamos a la coleccion
        Dictionary<string, long> diccionario = new Dictionary<string, long>();

        do
        {
            //Menu
            Console.WriteLine("1. Agregar Contacto.");
            Console.WriteLine("2. Buscar Contacto");
            Console.WriteLine("3. Eliminar Contacto.");
            Console.WriteLine("4. Mostrar Contactos.");
            Console.WriteLine("5. Salir.");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del contacto: ");
                    nombre = Console.ReadLine() ?? "";
                    Console.WriteLine("Ingrese el numero del contacto: ");
                    numero = Convert.ToInt64(Console.ReadLine());

                    if (numero.ToString().Length >= 5 && numero.ToString().Length <= 10)
                    {
                        Console.WriteLine("Contacto agregado");
                        diccionario.Add(nombre, numero);
                    }
                    else
                    {
                        Console.WriteLine("Tu contacto debe tener arriba de 5  y menos de 10 digitos ");
                    }

                    break;

                case 2:
                    bool encontrado;
                    Console.WriteLine("Ingrese el nombre del contacto: ");
                    buscarContacto = Console.ReadLine() ?? "";

                    if (diccionario.ContainsKey(buscarContacto))
                    {
                        encontrado = true;
                        Console.WriteLine("Contacto encontrado nombre: " + buscarContacto + "  Numero: " + diccionario[buscarContacto]);
                    }
                    else
                    {
                        encontrado = false;
                        Console.WriteLine("El contacto No se encuentra con este nombre");
                    }
                    break;
                case 3:
                Console.WriteLine("Ingrese el nombre de la persona a eliminar: ");
                buscarContacto = Console.ReadLine() ?? "";

                 if (diccionario.ContainsKey(buscarContacto))
                    {
                        encontrado = true;
                        Console.WriteLine("Contacto encontrado nombre: " + buscarContacto + "  Numero: " + diccionario[buscarContacto]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Desea eliminar el contacto (Si/No)?");
                        confirmar =  Console.ReadLine()?.ToLower().ToUpper() ?? "";

                        if(confirmar == "si")
                        {
                            diccionario.Remove(buscarContacto);
                            Console.WriteLine("Contacto Eliminado " + buscarContacto);
                        }
                    }
                    else
                    {
                        encontrado = false;
                        Console.WriteLine("El contacto No se encuentra con este nombre");
                    }
                
                break;
                case 4:

                foreach (var contactos in diccionario)
                {
                        Console.WriteLine("Nombres " + contactos.Key + " contactos " + contactos.Value );
                } 

                break;
                
                default: 
                    Console.WriteLine("Adios");
                break;
            }

        } while (opcion >= 1 && opcion <= 4);



    }
}