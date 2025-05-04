using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Busquedas
{
    public class BusquedaLineal
    {
        // Método genérico que realiza la búsqueda lineal en un arreglo
        public static int Buscar<T>(T[] arreglo, T objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i].Equals(objetivo))
                    return i; // Retorna el índice si se encuentra
            }
            return -1; // No encontrado
        }
    }
}
