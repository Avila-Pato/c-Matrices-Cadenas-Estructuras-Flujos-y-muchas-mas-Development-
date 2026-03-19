
namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando un objeto de la clase Automovil
            Automovil miAuto = new Automovil();

            miAuto.Color = "Negro";
            miAuto.Modelo = "Sedan";
            miAuto.Combustible = "Gasolina";

            Console.WriteLine("Mi auto es de color: " + miAuto.Color + ", modelo: " + miAuto.Modelo + ", y usa combustible: " + miAuto.Combustible);

            miAuto.Ano = 2020;
            miAuto.NumPuertas = 4;
            miAuto.CcMotor = 2000;

            Console.WriteLine("Mi auto es del año: " + miAuto.Ano + ", tiene " + miAuto.NumPuertas + " puertas y un motor de " + miAuto.CcMotor + " cc.");

            // usando ToString 
            Console.WriteLine(miAuto.ToString());

            // miAuto.Acelerar();
        }

        public class Automovil
        {
            private string color, modelo, combustible;
            private int ano, numPuertas;
            private int ccMotor;


            // Ejemplos para campos inicializados con el constructor
            private string asientos, colorTablero;
            private bool aireAcondicionado;

            //Constructor
            public Automovil()
            {
                asientos = "Cuero";
                colorTablero = "CAFE";
                aireAcondicionado = true;
            }


            //Propiedades
            //[acceco][tipo de dato][nombre de la propiedad]
            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }

            public string Combustible
            {
                get { return combustible; }
                set { combustible = value; }
            }
            // Metodo miembros con forma de expresion es una 2 forma de hacer get y set
            public int Ano
            {
                get => ano;
                set => ano = value;
            }

            public int NumPuertas
            {
                get => numPuertas;
                set => numPuertas = value;
            }

            public int CcMotor
            {
                get => ccMotor;
                set => ccMotor = value;
            }


            // Metodos
            public bool Acelerar()
            {
                bool acelerando = true;
                Console.WriteLine("El automovil esta acelerando");
                return acelerando;
            }
            public bool Frenar()
            {
                bool frenando = true;
                Console.WriteLine("El automovil esta frenando");
                return frenando;
            }

            // invalidando el ToString con override
            public override string ToString()
            {
                string mensaje;
                mensaje = "El Color es " + Color +
                ", el Modelo es " + Modelo + ", el Combustible es "
                + Combustible + ", el Año es "
                + Ano + ", el Número de Puertas es " + NumPuertas
                + " y el CC del Motor es " + CcMotor +
                // agregando los campos inicializados con el constructor al mensaje del ToString
                ", los Asientos son de " + asientos + ", el Color del Tablero es " + colorTablero + " y el Aire Acondicionado es " + aireAcondicionado;
                return mensaje;


            }
        }
    }
}