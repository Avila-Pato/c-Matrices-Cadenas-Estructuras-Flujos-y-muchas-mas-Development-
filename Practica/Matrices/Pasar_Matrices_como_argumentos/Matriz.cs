

// invocamos metodo unidimensional
int[] matriz = new int[3] { 1, 2, 3 }; 
ImprimirMatriz(matriz);

//invocamos metodo multifuncional
double [,] matrizMulti = new double[2, 3] { { 1.5, 2.5, 3.5 }, { 4.5, 5.5, 6.5 } };
ImprimirMatrizMulti(matrizMulti);


static void ImprimirMatriz(int[] matriz)
{
    for (int i = 0; i < matriz.Length; i++)
    {
        Console.WriteLine(matriz[i]);
    }
}

static void ImprimirMatrizMulti(double[,] matrizMulti) 
{
        for (int i = 0; i < matrizMulti.GetLength(0); i++) // Fila
        {
            for (int j = 0; j < matrizMulti.GetLength(1); j++) // Columna
            {
                Console.Write(matrizMulti[i, j] + " ");
            }
            Console.WriteLine();

        }
}

