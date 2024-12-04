using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz { get; set; }
        public String strArbol;
        public String strRecorrido;


        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            } else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }


        public bool BuscarNodo(int Dato, NodoBinario nodo)
        {
            if (nodo == null) return false;

            if (nodo.Dato == Dato) return true;

            // Busca en el subárbol izquierdo o derecho
            if (Dato < nodo.Dato)
                return BuscarNodo(Dato, nodo.Izq);
            else
                return BuscarNodo(Dato, nodo.Der);
        }

        public void Podar(NodoBinario nodo)
        {
            if (nodo == null) return;

            nodo.Izq = null;  // Elimina el subárbol izquierdo
            nodo.Der= null;    // Elimina el subárbol derecho
        }

        public void EliminarNodoPredecesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null) return;

            if (valor < nodo.Dato)
            {
                // Si el valor es menor, sigue buscando en el subárbol izquierdo
                EliminarNodoPredecesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                // Si el valor es mayor, sigue buscando en el subárbol derecho
                EliminarNodoPredecesor(valor, ref nodo.Der);
            }
            else
            {
                // Nodo encontrado
                if (nodo.Izq != null && nodo.Der != null)
                {
                    // Si tiene dos hijos, busca el predecesor en el subárbol izquierdo
                    NodoBinario predecesor = EncontrarMaximo(nodo.Izq);
                    nodo.Dato = predecesor.Dato; // Remplaza el valor del nodo con el predecesor
                    EliminarNodoPredecesor(predecesor.Dato, ref nodo.Izq); // Elimina el predecesor
                }
                else
                {
                    // Caso con 0 o 1 hijo
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }
        }

        // Método auxiliar para encontrar el nodo con el valor máximo en el subárbol izquierdo
        private NodoBinario EncontrarMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }

        public string RecorrerPorNiveles(NodoBinario raiz)
        {
            if (raiz == null)
            {
                return "El árbol está vacío.";
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>(); // Cola para el recorrido por niveles
            StringBuilder resultado = new StringBuilder(); // Acumulador para los valores del recorrido

            cola.Enqueue(raiz); // Comienza desde la raíz

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                resultado.Append(nodoActual.Dato + " "); // Agrega el valor del nodo al resultado

                // Encola el hijo izquierdo si existe
                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }

                // Encola el hijo derecho si existe
                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }

            return resultado.ToString().Trim(); // Retorna el resultado del recorrido por niveles
        }

        public int ObtenerAltura(NodoBinario nodo)
        {
            // Si el nodo es nulo, la altura es 0
            if (nodo == null)
            {
                return 0;
            }

            // Calcula la altura del subárbol izquierdo
            int alturaIzquierda = ObtenerAltura(nodo.Izq);
            // Calcula la altura del subárbol derecho
            int alturaDerecha = ObtenerAltura(nodo.Der);

            // La altura es la mayor de las dos alturas más uno (para el nodo actual)
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }

        public int ContarHojas(NodoBinario nodo)
        {
            // Si el nodo es nulo, no hay hojas
            if (nodo == null)
            {
                return 0;
            }

            // Si el nodo no tiene hijos, es una hoja
            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1;
            }

            // Suma las hojas de los subárboles izquierdo y derecho
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos(NodoBinario nodo)
        {
            // Si el nodo es nulo, no hay nodos en este subárbol
            if (nodo == null)
            {
                return 0;
            }

            // Cuenta el nodo actual y suma los nodos de los subárboles izquierdo y derecho
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        public bool EsArbolBinarioCompleto(NodoBinario raiz)
        {
            if (raiz == null)
            {
                return true; // Un árbol vacío es considerado completo
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(raiz);

            bool encontradoNodoIncompleto = false;

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();

                // Verifica el hijo izquierdo
                if (nodoActual.Izq != null)
                {
                    // Si ya encontramos un nodo incompleto antes, no puede ser completo
                    if (encontradoNodoIncompleto)
                    {
                        return false;
                    }
                    cola.Enqueue(nodoActual.Izq);
                }
                else
                {
                    // Si no tiene hijo izquierdo, el resto de los nodos deben estar incompletos
                    encontradoNodoIncompleto = true;
                }

                // Verifica el hijo derecho
                if (nodoActual.Der != null)
                {
                    // Si ya encontramos un nodo incompleto antes, no puede ser completo
                    if (encontradoNodoIncompleto)
                    {
                        return false;
                    }
                    cola.Enqueue(nodoActual.Der);
                }
                else
                {
                    // Si no tiene hijo derecho, el resto de los nodos deben estar incompletos
                    encontradoNodoIncompleto = true;
                }
            }

            return true; // Si no se detectaron nodos fuera de lugar, es completo
        }

        public bool EsArbolBinarioLleno(NodoBinario nodo)
        {
            // Un árbol vacío es considerado binario lleno
            if (nodo == null)
            {
                return true;
            }

            // Si el nodo no tiene hijos, es una hoja y cumple la condición
            if (nodo.Izq == null && nodo.Der == null)
            {
                return true;
            }

            // Si el nodo tiene ambos hijos, revisa recursivamente los subárboles
            if (nodo.Izq != null && nodo.Der != null)
            {
                return EsArbolBinarioLleno(nodo.Izq) && EsArbolBinarioLleno(nodo.Der);
            }

            // Si el nodo tiene solo un hijo, el árbol no es lleno
            return false;
        }


        public NodoBinario EliminarNodoSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo; // El nodo no está en el árbol
            }

            // Si el valor es menor, recorre el subárbol izquierdo
            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoSucesor(nodo.Izq, valor);
            }
            // Si el valor es mayor, recorre el subárbol derecho
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoSucesor(nodo.Der, valor);
            }
            else
            {
                // Caso 1: El nodo no tiene hijos
                if (nodo.Izq == null && nodo.Der == null)
                {
                    return null;
                }
                // Caso 2: El nodo tiene solo un hijo
                else if (nodo.Izq == null)
                {
                    return nodo.Der;
                }
                else if (nodo.Der == null)
                {
                    return nodo.Izq;
                }
                // Caso 3: El nodo tiene dos hijos
                else
                {
                    // Encuentra el sucesor (mínimo en el subárbol derecho)
                    NodoBinario sucesor = EncontrarMinimo(nodo.Der);
                    nodo.Dato = sucesor.Dato;

                    // Elimina el sucesor en el subárbol derecho
                    nodo.Der = EliminarNodoSucesor(nodo.Der, sucesor.Dato);
                }
            }
            return nodo;
        }

        // Método auxiliar para encontrar el nodo con el valor mínimo en un subárbol
        private NodoBinario EncontrarMinimo(NodoBinario nodo)
        {
            NodoBinario actual = nodo;

            while (actual.Izq != null)
            {
                actual = actual.Izq;
            }

            return actual;
        }



    }
}


