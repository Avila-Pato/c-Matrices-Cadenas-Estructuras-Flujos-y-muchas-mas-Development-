class Matriz
{
    public static void MainOLD(string[] args)
    {
        // tipo de dato[,] nombre = new tipo de dato[filas, columnas];
        // Matriz de 3 filas y 4 columnas
        int[,] ventas = new int[3, 4] { 
            { 10, 20, 30, 40 }, 
            { 15, 25, 35, 45 }, 
            { 12, 22, 32, 42 }
        };

        ventas[1,2] = 50; // Modificar el valor en la fila 1, columna 2
        Console.WriteLine(ventas[1,2]); // Imprime el valor modificado (50)
        // ver toda la matriz
    
        for (int i = 0; i < ventas.GetLength(0); i++) // GetLength(0) devuelve el número de filas
        {
            for (int j = 0; j < ventas.GetLength(1); j++) // GetLength(1) devuelve el número de columnas
            {
                Console.Write(ventas[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // Otra forma de recorrer la matriz usando con for
         int i, j;
        for(i = 0; i < 4; i++)
        {
                Console.WriteLine("fila" + i); 
            for(j = 0; j < 3; j++)
            {
                Console.Write(ventas[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // declaracon e instancia de matriz de 3 dimensiones (2 bloques, 3 filas y 4 columnas)
        // int[,,] matriz3D = new int[2, 3, 4] {
        //     { 
        //         { 1, 2, 3, 4 }, 
        //         { 5, 6, 7, 8 }, 
        //         { 9, 10, 11, 12 } 
        //     },
        //     { 
        //         { 13, 14, 15, 16 }, 
        //         { 17, 18, 19, 20 }, 
        //         { 21, 22, 23, 24 } 
        //     }
        // };
        }
    }