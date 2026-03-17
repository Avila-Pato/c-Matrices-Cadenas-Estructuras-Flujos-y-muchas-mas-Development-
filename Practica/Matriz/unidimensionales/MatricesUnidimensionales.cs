class Tarea
{
    public static void MainOld(string[] args)
    {
        // variables
        byte i, numAlumnos;
        double sumaCalificaciones = 0, promedio, caliMin = 10, caliMax = 0;

        //Pedimos el numero de alumnos
        Console.Write("Ingresa el número de alumnos: ");
        numAlumnos = Convert.ToByte(Console.ReadLine());

        //Creacion de la matriz
        double[] calificaciones = new double[numAlumnos];

        //for para pedir calificaciones
        for(i = 0; i < numAlumnos; i++)
        {
            Console.Write("Ingresa la calificación del alumno {0}: ", i + 1);
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());

            //Sumamos las calificaciones
            sumaCalificaciones += calificaciones[i];
        }

            //Obtenemos el promedio
            promedio = sumaCalificaciones / numAlumnos;

            //Obtenemos la calificación mínima
            for(i = 0; i < numAlumnos; i++)
            {
                if(calificaciones[i] < caliMin)
                {
                    caliMin = calificaciones[i];
                }

            }
            //Obtenemos la calificación máxima
            for(i = 0; i < numAlumnos; i++)
            {
                if(calificaciones[i] > caliMax)
                {
                    caliMax = calificaciones[i];
                }

            }
            //Mostramos los resultados

            Console.WriteLine("El promedio de las calificaciones es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", caliMin);
            Console.WriteLine("La calificación máxima es: {0}", caliMax);
    }
}