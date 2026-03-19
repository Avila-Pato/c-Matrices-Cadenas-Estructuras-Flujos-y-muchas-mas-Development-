using System;

namespace Clases
{
    public class Ejercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al banco, por favor ingresa tu nombre:");
            string nombre = Console.ReadLine() ?? "";

            Console.WriteLine("Ahora ingresa tu apellido:");
            string apellido = Console.ReadLine() ?? "";

            Console.WriteLine("Ahora ingresa tu direccion:");
            string direccion = Console.ReadLine() ?? "";

            Console.WriteLine("Ahora ingresa tu RFC:");
            string rfc = Console.ReadLine() ?? "";

            Console.WriteLine("Ahora ingresa tu saldo:");
            double saldo = Convert.ToDouble(Console.ReadLine() ?? "0");

            // Crear objeto correctamente
            CuentaBancaria cuenta = new CuentaBancaria(nombre, apellido, direccion, rfc, saldo);

            Console.WriteLine("\nDatos de la cuenta:");
            Console.WriteLine(cuenta.ToString());

            // Ejecutar menú
            cuenta.Menu();
        }
    }

    public class CuentaBancaria
    {
        // Campos
        private string nombre, apellido, direccion, rfc;
        private double saldo;

        // Constructor
        public CuentaBancaria(string nombrePa, string apellidoPa, string direccionPa, string rfcPa, double saldoPa)
        {
            this.nombre = nombrePa;
            this.apellido = apellidoPa;
            this.direccion = direccionPa;
            this.rfc = rfcPa;
            this.saldo = saldoPa;
        }

        // Métodos privados
        private void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine("Depósito realizado.");
        }

        private void Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("No tienes saldo suficiente.");
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine("Retiro realizado.");
            }
        }

        private void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + saldo);
        }

        // MENÚ (ya dentro de la clase y funcional)
        public void Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese cantidad a depositar:");
                        double dep = Convert.ToDouble(Console.ReadLine() ?? "0");
                        Depositar(dep);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese cantidad a retirar:");
                        double ret = Convert.ToDouble(Console.ReadLine() ?? "0");
                        Retirar(ret);
                        break;

                    case 3:
                        ConsultarSaldo();
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el banco.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\n" +
                   "Apellido: " + apellido + "\n" +
                   "Direccion: " + direccion + "\n" +
                   "RFC: " + rfc + "\n" +
                   "Saldo: " + saldo;
        }
    }
}