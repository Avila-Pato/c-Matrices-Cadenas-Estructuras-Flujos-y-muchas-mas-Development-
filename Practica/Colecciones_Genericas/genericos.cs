
class Genericos
{
    public static void Mainold(string[] args)
    {
        // varaiobles locales
        Alumno valoresElemento;

        //instanciamos clases
        GuardaObjetos<string> objeto1 = new GuardaObjetos<string>(3);

        objeto1.AgregarElementos("Cadena 1");
        objeto1.AgregarElementos("Cadena 2");
        objeto1.AgregarElementos("Cadena 3");

        

        
        // obtenemos el elemento en la posicion 1
        string valoresLocales = (string)objeto1.ObtenerElemento(1);
        Console.WriteLine(valoresLocales);


        // instanciamos objetos
        Alumno alumno1 = new Alumno(7.5);
        Alumno alumno2 = new Alumno(8.5);
        Alumno alumno3 = new Alumno(9.5);

        // instanciamos la coleccion
        List<Alumno> listaAlumnos = new List<Alumno>();

        // Agregamos los alumnos
        listaAlumnos.Add(alumno1);
        listaAlumnos.Add(alumno2);
        listaAlumnos.Add(alumno3);

        // Recorremos la coleccion
        foreach (Alumno alumno in listaAlumnos)
        {
            Console.WriteLine(alumno.Calificacion);
        }
 



    }
    class GuardaObjetos<T> // Generico <T> AYUUDA A IDENTIFICAR EL TIPO
    {
        // Campos
        private int i = 0;
        private T[] matrizElementos;

        //Constructotor
        public GuardaObjetos(int elementos)
        {
            matrizElementos = new T[elementos];
        }

        //Metodos 
        public void AgregarElementos(T elemento)
        {
            matrizElementos[i] = elemento;
            i++;
        }
        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }

    // No genericos
    class Alumno
    {
        //Campos
        double calificacion;

        //Cobnstructir
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }
        //Propiedades
        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
    }




}
