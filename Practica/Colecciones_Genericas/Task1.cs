using System.Data.Common;

class Task1
{
    public static void MainOld(string[] args)
    {
        // Varaibles locales 
        int opcion;
        string elemento;

        // instancia de colecciones
        List<string> personas = new List<string>();

        do
        {
            Console.WriteLine("1. Agregar persona");
            Console.WriteLine("2. Borrar persona.");
            Console.WriteLine("3. Mostrar personas.");
            Console.WriteLine("4. salir.");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Agregar Persona: ");
                elemento = Console.ReadLine() ?? "";

                if (personas.Contains(elemento))
                {
                    Console.WriteLine("La persona ya existe");
                }
                else
                {
                    personas.Add(elemento);
                }

            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingrese el nombre de la persona: ");
                elemento = Console.ReadLine() ?? "";

                if (personas.Contains(elemento))
                {
                    personas.Remove(elemento);
                    Console.WriteLine("Persona borrada");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada");
                }


            }

            if (opcion == 3)
            {
                if (personas.Count == 0)
                {
                    Console.WriteLine("No hay personas Agregadas");
                }
                else
                {
                    foreach (string persona in personas)
                    {
                        Console.WriteLine(persona);
                    }
                }


            }


        } while (opcion != 4);
        {
            Console.WriteLine("Adios");
        }
    }
}