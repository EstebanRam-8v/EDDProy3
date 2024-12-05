using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Cola
    {
        public class Colas
        {
            private Queue<string> queue;

            public Colas()
            {
                queue = new Queue<string>();
            }

            // Agrega un elemento a la cola
            public void Enqueue(string item)
            {
                queue.Enqueue(item);
            }

            // Elimina y devuelve el primer elemento de la cola
            public string Dequeue()
            {
                return queue.Count > 0 ? queue.Dequeue() : null;
            }

            // Verifica si un elemento existe en la cola
            public bool Contains(string item)
            {
                return queue.Contains(item);
            }

            // Limpia todos los elementos de la cola
            public void Clear()
            {
                queue.Clear();
            }

            // Devuelve todos los elementos en la cola
            public IEnumerable<string> GetAllItems()
            {
                return queue;
            }

            // Obtiene la cantidad de elementos en la cola
            public int Count()
            {
                return queue.Count;
            }

        }
    }
}
