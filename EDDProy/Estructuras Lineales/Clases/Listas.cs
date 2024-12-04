using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    class Listas
    {
        private List<string> lista;

        public Listas()
        {
            lista = new List<string>();
        }

        // Agrega un elemento a la lista
        public void Agregar(string item)
        {
            if (!string.IsNullOrWhiteSpace(item))
            {
                lista.Add(item);
            }
            else
            {
                throw new ArgumentException("El elemento no puede estar vacío.");
            }
        }

        public bool Eliminar(string item)
        {
            return lista.Remove(item);
        }

        // Verifica si un elemento existe en la lista
        public bool Contiene(string item)
        {
            return lista.Contains(item);
        }

        // Limpia todos los elementos de la lista
        public void Limpiar()
        {
            lista.Clear();
        }
        // Obtiene todos los elementos de la lista
        public IEnumerable<string> ObtenerTodos()
        {
            return lista;
        }

        // Devuelve la cantidad de elementos en la lista
        public int Contar()
        {
            return lista.Count;
        }
    }
}
