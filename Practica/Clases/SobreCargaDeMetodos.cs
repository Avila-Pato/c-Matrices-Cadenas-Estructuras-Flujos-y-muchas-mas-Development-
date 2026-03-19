namespace SobreCargaDeMetodos
{
    class SobrecargaDeMetodos
    {
        public static void MainOLD(string[] args)
        {
                // Instanciando un objeto de la clase Nombres
                Nombres nombres = new Nombres();
                // Llamando al método Concatenar para obtener el nombre completo
                string nombreCompleto = nombres.Concatenar("Juan", "Pérez");
                Console.WriteLine("El nombre completo es: " + nombreCompleto);

                // Llamando al método Concatenar para obtener el nombre completo con segundo nombre
                string nombreCompletoConSegundoNombre = nombres.Concatenar("Juan", "Carlos", "Pérez");
                Console.WriteLine("El nombre completo es: " + nombreCompletoConSegundoNombre);

        }
    }

    class Nombres
    {
        //Metodos
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa;

            return nombreApellido;
        }
        // Sobrecarga del método Concatenar para aceptar un segundo nombre
        public string Concatenar(string nombrePa, string segundoNombrePa, string apellidoPa)
        {
            string nombreCompleto;

            nombreCompleto = nombrePa + " " + segundoNombrePa + " " + apellidoPa;

            return nombreCompleto;
        }
    }


    // metodo RANDOM para mostrar la sobrecarga de metodos con diferentes tipos de parametros
    class GeneradorAleatorio
    {
        public int GenerarNumero(int min = 0, int max = 100)
        {
            System.Random random = new System.Random();
            int numero = random.Next(min, max);
            Console.WriteLine("El número aleatorio generado es: " + numero);
            return numero;
        }

        public double GenerarNumero(double min = 0, double max = 100)
        {
            System.Random random = new System.Random();
            double numero = random.NextDouble() * (max - min) + min;
            Console.WriteLine("El número aleatorio generado es: " + numero);
            return numero;
        }
    }
}