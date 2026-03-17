

  class Matriz
  {
      public static void MainOld(string[] args)
      {
            // double[,] matriz = new double[3, 3]; // matriz 3x3

            // int[] ints = new int[3] { 1, 2, 3 }; // arreglo de enteros

            // string[] strings = new string[3] { "Hola", "Mundo", "!" }; // arreglo de cadenas

            // byte[] bytes = new byte[3] { 0x00, 0xFF, 0x7F }; // arreglo de bytes

            // double[] calificaciones = new decimal[4];

            // Asignar valores al elemento de la  matriz
            // calificaciones[0] = 9;
            // calificaciones[1] = 10;
            // calificaciones[2] = 7.6;
            // calificaciones[3] = 8.5;
            byte i;

            string[] nombres = new string[3];

            // // Asignar valores al elemento del arreglo de cadenas
            // nombres[0] = "Juan";
            // nombres[1] = "María";
            // nombres[2] = "Pedro";
            

            for(i = 0; i <= 2; i++)
            {
                Console.Write("Ingresa el nombre del alumno {0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }

            for(i = 0; i <= 2; i++)
            {
                Console.WriteLine("El alumno {0} se llama {1}", i + 1, nombres[i]);
            }

      }
  }