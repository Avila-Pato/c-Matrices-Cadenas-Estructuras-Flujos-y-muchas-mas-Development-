namespace Clases
{
    class Ejercicio1
    {
        public static void MainOOld(string[] args)
        {
            // Variables
            string nombre, apellido, nip;
            Console.WriteLine("Bienvenido a la empresa, por favor ingresa tu nombre: \n");
            nombre = Console.ReadLine();
            Console.WriteLine("Ahora ingresa tu apellido: \n");
            apellido = Console.ReadLine();
            Console.WriteLine("Por último, ingresa tu NIP: \n");
            nip = Console.ReadLine();

            // Instanciamos a la clase empleado
            Empleado empleado = new Empleado(nombre, apellido);
            empleado.Nip = nip;
            Console.WriteLine(empleado.ToString());


        }
    }

    class Empleado
    {
        // Campos
        private string nombre, apellido, id, locker, banco, nip;

        // Constructor
        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

            //  llamando a los metodos para generar el id, locker y asignar el banco
            this.id = GenerarId();
            this.locker = GenerarLocker();
            this.banco = AsignarBanco();
        }

        //Propiedades
        public string Nip
        {

            set => nip = value;
        }

        private string GenerarId()
        {
            // instanaciamos a random para generar un id aleatorio
            Random random = new Random();

            // variables
            int numero;
            string id = "";
            for (int i = 0; i < 10; i++)
            {
                numero = random.Next(0, 10);
                id += numero.ToString(); // es toString porque numero es un entero y queremos concatenarlo a una cadena ""
                                         // por eso se va ir acumulando ["5", "3", "7", "1", "9", "0", "2", "8", "4"] 
                                         // y al final se va a convertir en una cadena de 10 caracteres con numeros aleatorios
            }
            return id;
        }

        private string GenerarLocker()
        {
            // instanaciamos a random para generar un id aleatorio
            Random random = new Random();

            // variables
            int numero;
            string locker = "";
            for (int i = 0; i < 2; i++)
            {
                numero = random.Next(0, 10);
                locker += numero.ToString(); // es toString porque numero es un entero y queremos concatenarlo a una cadena ""
                                             // por eso se va ir acumulando ["5", "3", "7", "1", "9", "0", "2", "8", "4"] 
                                             // y al final se va a convertir en una cadena de 10 caracteres con numeros aleatorios
            }
            return locker;
        }
        private string AsignarBanco()
        {

            // instanciamos a random
            Random random = new Random();

            // Variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
                default:
                    banco = "No se asigno un banco";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "Empleado: " + nombre + " " + apellido + "\n" +
                      "ID: " + id + "\n" +
                      "Locker: " + locker + "\n" +
                      "Banco: " + banco + "\n" +
                      "NIP: " + nip;

            return mensaje;
        }

    }


}