// Matrices Escalonadas (jagged) // es una matriz donde  sus elementos tambien son matrices,
//  pero estas pueden tener diferentes tamaños


class Matriz
{
    public static void MainOLD(string[] args)
    {
        // tipo [][] nombre = new tipo [filas][columnas]
        // 4 matrices internas (4 filas)
        double[][] ventas = new double[4][]
        {
                //Declaracion de las matrices internas (columnas)
                new double[3] {155, 100, 177}, // 3 columnas = fila 0
                new double[2] {205, 120}, // 2 columnas = fila 1
                new double[4] {120, 190, 104, 120}, // 4 columnas = fila 2
                new double[3] {163, 218, 125} // 3 columnas = fila 3
            };

            Console.WriteLine(ventas[0][2]);  // Imprime el valor en la posición [0][2] (177) // de manera escalonada

    // int[] numerosPrueba = new int[] { 1, 2, 3, 4, 5 }; // matriz unidimensional
    // Console.WriteLine(numerosPrueba.Length); // Imprime el valor en la posición 2 (3)

    // double[,] ventas2d = new double[4, 4] // Matriz bidimensional (rectangular)
    // {
    //     {155, 100, 177, 0}, // Fila 1
    //     {205, 120, 0, 0},   // Fila 2
    //     {120, 190, 104, 120}, // Fila 3
    //     {163, 218, 125, 0}   // Fila 4
    // };


    // Console.WriteLine(ventas2d[0, 2]); // Imprime el valor en la posición [0, 2] (177)
    // Console.WriteLine(ventas2d.GetLength(0)); // imprime el número de filas 
    // Console.WriteLine(ventas2d.GetLength(1)); // imprime el número de columnas y el número de elementos en cada fila (4)

    }

    //Declaracion de las matrices internas (columnas) 2 formas de hacerlo
    // ventas[0] = new double[3] {155, 100, 177}; // 3 columnas
    // ventas[1] = new double[2] {205, 120}; // 2 columnas
    // ventas[2] = new double[4] {120, 190, 104, 120}; // 4 columnas
    // ventas[3] = new double[3] {163, 218, 125}; // 3 columnas
    


}
