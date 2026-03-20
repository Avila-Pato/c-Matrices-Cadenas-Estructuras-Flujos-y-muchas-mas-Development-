
class Genericos
{
    public static void Main(string[] args)
    {
        // varaiobles locales
        string valoresLocales;

        //instanciamos clases
        GuardaObjetos objeto1 = new GuardaObjetos(3);

        objeto1.AgregarElementos("Cadena 1");
        objeto1.AgregarElementos("Cadena 2");
        objeto1.AgregarElementos("Cadena 3");
        

        //obtenemos el elemento en la posicion 1
        valoresLocales = (string)objeto1.ObtenerElemento(1);
        Console.WriteLine(valoresLocales);

    }
    class GuardaObjetos
    {
        // Campos
        private int i = 0;
        private object[] matrizElementos;

        //Constructotor
        public GuardaObjetos(int elementos)
        {
            matrizElementos = new object[elementos];
        }

        //Metodos 
        public void AgregarElementos(object elemento)
        {
            matrizElementos[i] = elemento;
            i++;
        }
        public object ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }

    }




}
