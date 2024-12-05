using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class ListaCircularDoble
    {

        private Nodo cabeza;

        public ListaCircularDoble()
        {
            cabeza = null;
        }

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Siguiente = cabeza;
                cabeza.Anterior = cabeza;
            }
            else
            {
                Nodo ultimo = cabeza.Anterior;
                nuevo.Siguiente = cabeza;
                nuevo.Anterior = ultimo;
                cabeza.Anterior = nuevo;
                ultimo.Siguiente = nuevo;
            }
        }

        public string Mostrar()
        {
            if (cabeza == null)
                return "La lista está vacía.";

            Nodo actual = cabeza;
            string resultado = "";

            do
            {
                resultado += actual.Valor + " ";
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return resultado.Trim();
        }

        public bool Buscar(int valor)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Valor == valor)
                    return true;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        public bool Eliminar(int valor)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Valor == valor)
                {
                    if (actual == cabeza && cabeza.Siguiente == cabeza)
                    {
                        cabeza = null; // Era el único nodo
                    }
                    else
                    {
                        Nodo anterior = actual.Anterior;
                        Nodo siguiente = actual.Siguiente;

                        anterior.Siguiente = siguiente;
                        siguiente.Anterior = anterior;

                        if (actual == cabeza)
                            cabeza = siguiente;
                    }
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }
    }
}

