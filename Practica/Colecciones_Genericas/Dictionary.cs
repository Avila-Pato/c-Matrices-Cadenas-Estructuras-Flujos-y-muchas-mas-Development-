class Dictionary
{
    public static void Main(string[] args)
    {
        // Instanciando un diccionario de claves de tipo string y valores de tipo int 
        Dictionary<string, int> empleados = new Dictionary<string, int>(); 

        // Agregando elementos al diccionario
        // empleados.Add("Juan", 25); // Clave: "Juan", Valor: 25
        // empleados.Add("María", 30); // Clave: "María", Valor: 30
        // empleados.Add("Pedro", 35); // Clave: "Pedro", Valor: 35

        foreach (KeyValuePair<string, int> empleado in empleados)
        {
            Console.WriteLine("Empleado: {0}, Edad: {1}", empleado.Key, empleado.Value); // Imprime: Empleado: Juan, Edad: 25, Empleado: María, Edad: 30, Empleado: Pedro, Edad: 35
        }

        // Agregar otro elemento al diccionario
        empleados.Add("Luis", 40); // Clave: "Luis", Valor: 40
        // Segunda forma de agregar un elemento al diccionario
        empleados["Ana"] = 45; // Clave: "Ana", Valor: 45 //

        // Nueva lista

        foreach(KeyValuePair<string, int> empleado in empleados)
        {
            Console.WriteLine("Empleado: {0}, Edad: {1}", empleado.Key, empleado.Value);
        }

        //Quitar elemento

        Console.WriteLine("\n Despues de remover un elemento");

        empleados.Remove("Luis");

        foreach (KeyValuePair<string, int> empleado in empleados)
        {
            Console.WriteLine("Empleado: {0}, Edad: {1}", empleado.Key, empleado.Value);
        }

        //Encontrar elemento

        Console.WriteLine("\n Despues de encontrar un elemento");

        if(empleados.ContainsKey("Juan"))
        {
            Console.WriteLine("El empleado Juan existe en el diccionario.");
        }
        else
        {
            Console.WriteLine("El empleado Juan no existe en el diccionario.");
        }
        if(empleados.ContainsValue(25))
        {
            Console.WriteLine("El empleado Juan existe en el diccionario.");
        }
        else
        {
            Console.WriteLine("El empleado Juan no existe en el diccionario.");
        }

    }
}