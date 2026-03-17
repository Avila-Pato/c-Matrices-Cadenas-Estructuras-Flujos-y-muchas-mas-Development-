class Tarea
{
    public static void Main(string[] args)
    {
        // variables
        byte i, j, numAlumnos, salones;
        double sumaCalificaciones = 0, promedio, caliMin = 10, caliMax = 0;

        //Pedimos el numero de alumnos
        Console.Write("Ingresa el número de alumnos: ");
        numAlumnos = Convert.ToByte(Console.ReadLine());

        //Pedimos el numero de salones
        Console.Write("Ingresa el número de salones: ");
        salones = Convert.ToByte(Console.ReadLine());

        //Creacion de la matriz, para almacenar las calificaciones de cada alumno en cada salón
        double[,] calificacionesSalones = new double[salones, numAlumnos];

        //for para pedir calificaciones
        for (i = 0; i < salones; i++)
        {
            for (j = 0; j < numAlumnos; j++)
            {
                Console.Write("Ingresa la calificación del alumno {0}: ", j + 1);
                calificacionesSalones[i, j] = Convert.ToDouble(Console.ReadLine());

                //Sumamos las calificaciones
                sumaCalificaciones += calificacionesSalones[i, j];
            }

        }

        //Obtenemos el promedio
        promedio = sumaCalificaciones / (salones * numAlumnos); // promedio total de la escuela

        //Obtenemos la calificación mínima
        for (i = 0; i < salones; i++)
        {
            for (j = 0; j < numAlumnos; j++)
            {
                if (calificacionesSalones[i, j] < caliMin)
                {
                    caliMin = calificacionesSalones[i, j];
                }

            }
        }
        //Obtenemos la calificación máxima
        for (i = 0; i < salones; i++)
        {
            for (j = 0; j < numAlumnos; j++)
            {
                if (calificacionesSalones[i, j] > caliMax)
                {
                    caliMax = calificacionesSalones[i, j];
                }

            }
        }
        //Mostramos los resultados

        Console.WriteLine("El promedio de las calificaciones es: {0}", promedio);
        Console.WriteLine("La calificación mínima es: {0}", caliMin);
        Console.WriteLine("La calificación máxima es: {0}", caliMax);
    }
}