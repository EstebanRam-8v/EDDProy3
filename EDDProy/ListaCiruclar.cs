using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public partial class ListaCircular
    {
        private Nodo cabeza;
        private Nodo cola;

        public ListaCircular() // Constructor único
        {
            cabeza = null;
            cola = null;
        }


        public void Insertar(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cabeza.Siguiente = cabeza; // Apunta a sí mismo, formando un ciclo
                cola = cabeza;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = cabeza;
                cola = nuevoNodo;
            }
        }

        public bool Buscar(string dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Dato == dato) return true;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        public bool Modificar(string datoAntiguo, string nuevoDato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Dato == datoAntiguo)
                {
                    actual.Dato = nuevoDato;
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        public bool Eliminar(string dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            Nodo anterior = null;
            do
            {
                if (actual.Dato == dato)
                {
                    if (anterior != null)
                    {
                        anterior.Siguiente = actual.Siguiente;
                        if (actual == cola)
                        {
                            cola = anterior;
                        }
                    }
                    else // Eliminando la cabeza
                    {
                        if (cabeza == cola) // Solo un elemento en la lista
                        {
                            cabeza = null;
                            cola = null;
                        }
                        else
                        {
                            cabeza = cabeza.Siguiente;
                            cola.Siguiente = cabeza;
                        }
                    }
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        public string MostrarLista()
        {
            if (cabeza == null) return "La lista está vacía.";

            StringBuilder listaStr = new StringBuilder();
            Nodo actual = cabeza;
            do
            {
                listaStr.Append(actual.Dato + " -> ");
                actual = actual.Siguiente;
            } while (actual != cabeza);

            listaStr.Append("(circular)");
            return listaStr.ToString();
        }

        private class Nodo
        {
            public string Dato { get; set; }
            public Nodo Siguiente { get; set; }

            public Nodo(string dato)
            {
                Dato = dato;
                Siguiente = null;
            }
        }
    }
}