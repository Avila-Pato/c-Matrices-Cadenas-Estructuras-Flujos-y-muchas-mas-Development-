using System.Linq.Expressions;

class Queue
{
    public static void MainOld(string[] args)
    {
        // Instanciando una cola
        Queue<char> cola = new Queue<char>();

        //Agregando objetos
        cola.Enqueue('a');
        cola.Enqueue('b');
        cola.Enqueue('c');

        int i = 0;
        foreach(char elemento  in cola)
        {
            Console.WriteLine("Elemento {0}: {1}", i++, elemento);
        }

        //Agregando otro elemento
        cola.Enqueue('d');

        //Sacando un elemento
        char elementoSacado = cola.Dequeue();
        Console.WriteLine("Sacamos el elemento: {0}", elementoSacado);

        //msotrando de neuvo los elemetos
        i = 0;
        foreach(char elemento in cola)
        {
            Console.WriteLine("Elemento {0}: {1}", i++, elemento);
        }

    }
}