// se omiten los [] al principio porque no es necesario para declarar una matriz con asignacion implicita de tipo
// ya que el compilador infiere el tipo de la matriz a partir de los valores que se le asignan

using Microsoft.VisualBasic;

namespace Seccion_Matrices
{
    class Matriz
    {
        public static void Main(string[] args)
        {
            // Matriz unidimensional con asignacion implicita de tipo
            var numeros = new[] { 1, 2, 3, 4, 5 };
            // Matriz bidimensional con asignacion implicita de tipo
            var matriz = new[,] { { 1, 2 }, { 3, 4 } };
            // Matriz multidimensional con asignacion implicita de tipo
            var matriz2D = new[,,] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        }

        // Matriz escalonada con asignacion implicita de tipo
        // el compilador ya sabe que vienen con 2 [][] en new[] y que cada una de esas matrices tiene un tipo de dato int,
        // asi por lo que infiere el tipo de la matriz jagged como VariantType
        VariantType matrizJagged = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 4, 5 },
            new[] { 6 }
        };
    }
}