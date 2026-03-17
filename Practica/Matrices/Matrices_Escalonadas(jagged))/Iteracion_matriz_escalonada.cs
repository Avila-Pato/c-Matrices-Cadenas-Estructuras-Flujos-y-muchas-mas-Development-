class Iteracion_matriz_escalonada
{
    public static void MainOLD(string[] args)
    {
        int i; // ciclo exterior
        int j; // ciclo interior

        double[][] ventas = new double[4][]
        {
                new double[3] {155, 100, 177},
                new double[2] {205, 120},
                new double[4] {120, 190, 104, 120},
                new double[3] {163, 218, 125}
        };
        

        for (i = 0; i < ventas.Length; i++)
        {
            Console.WriteLine("Elementos de la fila {0}:", i);
            for(j = 0; j < ventas[i].Length; j++)
            {
                Console.WriteLine(ventas[i][j]);
            }
            
        }
    }
}