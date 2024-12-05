using System;
using System.Text;

namespace EDDemo
{
    public class ListaCircular
    {
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

        private Nodo cabeza;

        public ListaCircular()
        {
            cabeza = null;
        }

        public void Insertar(string dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Siguiente = cabeza; // Apunta a sí mismo
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != cabeza)
                    temp = temp.Siguiente;
                temp.Siguiente = nuevo;
                nuevo.Siguiente = cabeza;
            }
        }

        public string MostrarLista()
        {
            if (cabeza == null) return "Lista vacía";

            StringBuilder sb = new StringBuilder();
            Nodo temp = cabeza;
            do
            {
                sb.Append(temp.Dato + " -> ");
                temp = temp.Siguiente;
            } while (temp != cabeza);

            return sb.ToString();
        }

        public bool Buscar(string dato)
        {
            if (cabeza == null) return false;

            Nodo temp = cabeza;
            do
            {
                if (temp.Dato == dato) return true;
                temp = temp.Siguiente;
            } while (temp != cabeza);

            return false;
        }

        public bool Modificar(string datoAntiguo, string nuevoDato)
        {
            if (cabeza == null) return false;

            Nodo temp = cabeza;
            do
            {
                if (temp.Dato == datoAntiguo)
                {
                    temp.Dato = nuevoDato;
                    return true;
                }
                temp = temp.Siguiente;
            } while (temp != cabeza);

            return false;
        }

        public bool Eliminar(string dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza, anterior = null;

            do
            {
                if (actual.Dato == dato)
                {
                    if (anterior != null)
                    {
                        anterior.Siguiente = actual.Siguiente;
                        if (actual == cabeza) cabeza = anterior.Siguiente;
                    }
                    else
                    {
                        if (cabeza.Siguiente == cabeza)
                        {
                            cabeza = null; // La lista queda vacía
                        }
                        else
                        {
                            Nodo temp = cabeza;
                            while (temp.Siguiente != cabeza)
                                temp = temp.Siguiente;
                            temp.Siguiente = cabeza.Siguiente;
                            cabeza = cabeza.Siguiente;
                        }
                    }
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

    }
}