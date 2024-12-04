using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class ListaDobles
    {
        private LinkedList<string> lista;

        public ListaDobles()
        {
            lista = new LinkedList<string>();
        }

        // Agrega un elemento al final de la lista
        public void Agregar(string item)
        {
            if (!string.IsNullOrWhiteSpace(item))
            {
                lista.AddLast(item);
            }
            else
            {
                throw new ArgumentException("El elemento no puede estar vacío.");
            }
        }

        // Elimina el primer elemento que coincide con el valor
        public bool Eliminar(string item)
        {
            return lista.Remove(item);
        }

        // Busca un elemento en la lista y devuelve true si existe
        public bool Buscar(string item)
        {
            return lista.Contains(item);
        }

        // Modifica el valor de un elemento existente en la lista
        public bool Modificar(string itemAntiguo, string nuevoItem)
        {
            var nodo = lista.Find(itemAntiguo);
            if (nodo != null)
            {
                nodo.Value = nuevoItem;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Devuelve una lista ordenada de los elementos
        public void Ordenar()
        {
            var listaOrdenada = new List<string>(lista);
            listaOrdenada.Sort();
            lista = new LinkedList<string>(listaOrdenada);
        }

        // Devuelve todos los elementos de la lista como un IEnumerable
        public IEnumerable<string> ObtenerTodos()
        {
            return lista;
        }

        // Devuelve el número de elementos en la lista
        public int Contar()
        {
            return lista.Count;
        }

        // Limpia la lista
        public void Limpiar()
        {
            lista.Clear();
        }
    }
}
