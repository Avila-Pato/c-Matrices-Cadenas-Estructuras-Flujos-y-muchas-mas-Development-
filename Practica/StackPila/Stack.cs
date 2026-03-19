namespace Stack
{
    class Stack
    {
        public static void MainOLD(string[] args)
        {
            int a = 2;
            string nombre = "Juan";
            float pi = 3.14f;

            MetodoPrueba(10, 20);

        // ReadKey(); se usa para pausar la consola y esperar a que el usuario presione una tecla antes de 
        // cerrar la ventana de la consola, lo que permite ver los resultados antes de que se cierre la aplicación
            Console.ReadKey();
        }

        static void MetodoPrueba(int x, int y)
        {
            int c = 5;

            Console.WriteLine(x + y + c);
        }
    }
}