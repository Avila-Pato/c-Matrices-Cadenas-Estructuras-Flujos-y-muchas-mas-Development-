class Stack_generico
{
    public static void MainOld(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        // El ultimo elemento en entrar es el primero en salir
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // foreach (int item in stack)
        // {
        //     Console.WriteLine(" {0}", item);

        // }

        // Insertar un elemento
        stack.Push(40);
        // indice 

        int i = 0;
        foreach (int item in stack)
        {
            // Console.WriteLine(" {0} {1}", i++, item);
            
        }

        // Sacar un elemento Pop
        int n = stack.Pop();

        // Console.WriteLine("Sacamos el elemento {0}", n);

        // neuva lista de elementos
        // Console.WriteLine("\nNueva lista de elementos");
        foreach (int item in stack)
        {
            Console.WriteLine(" {0}", item);
        }

        // Obtener un elemeto Peek
        // Console.WriteLine("\nObtenemos el elemento {0} este es el ultimo elemento pero sera el primero", stack.Peek());
        
        // Por ultimo encontrar un elemento con Containts

        //Varaibles
        int buscarElemento;
        bool contiene;

        Console.WriteLine("\nIngrese el elemento a buscar: ");
        buscarElemento = Convert.ToInt32(Console.ReadLine());

        if(stack.Contains(buscarElemento))
        {
            contiene = true;
            Console.WriteLine("El elemento {0} si se encuentra en la pila", buscarElemento);
        }
        else
        {
            contiene = false;
            Console.WriteLine("El elemento {0} no se encuentra en la pila", buscarElemento);
        }

    }
}