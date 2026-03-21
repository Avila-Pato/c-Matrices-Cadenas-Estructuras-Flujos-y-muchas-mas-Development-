class AddElement
{
    public static void MainOld(string[] args)
    {
        // Varaibles locales 
        int opcion;
        string elemento;

        // Instanciamos la coleccion
        List<string> personas = new List<string>();

        personas.Add("Pinocho");

        do
        {
           Console.WriteLine("1. Agregar persona");
           Console.WriteLine("2. Mostrar personas.");
           Console.WriteLine("3. salir.");
           opcion = Convert.ToInt32(Console.ReadLine());

           if(opcion == 1)
            {
                Console.WriteLine("Ingrese el nombre de la persona ");
                elemento = Console.ReadLine() ?? "";
                personas.Add(elemento);
            }

            if(opcion == 2)
            {
                foreach( string persona in personas)
                {
                    Console.WriteLine(persona);
                }
            }

        } while (opcion != 3);
        {
            Console.WriteLine("Adios");
        }


    }
}