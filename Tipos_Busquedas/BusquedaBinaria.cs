using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Busquedas
{
    public class BusquedaBinaria
    {
        // Método genérico para realizar búsqueda binaria
        public static int Buscar<T>(T[] arreglo, T objetivo) where T : IComparable<T>
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int comparacion = arreglo[medio].CompareTo(objetivo);

                if (comparacion == 0)
                    return medio;
                else if (comparacion < 0)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1; // No encontrado
        }
    }
}
