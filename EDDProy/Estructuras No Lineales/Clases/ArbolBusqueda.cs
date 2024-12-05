using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
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
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void GraficarArbol()
        {
            // Implementación de graficar el árbol usando Graphviz
        }

        public bool Buscar(int valor)
        {
            return Buscar(Raiz, valor);
        }

        private bool Buscar(NodoBinario nodo, int valor)
        {
            if (nodo == null) return false;
            if (nodo.Dato == valor) return true;
            return valor < nodo.Dato ? Buscar(nodo.Izq, valor) : Buscar(nodo.Der, valor);
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
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public void EliminarArbol()
        {
            Raiz = null;
        }

        public void EliminarNodoPredecesor(int valor)
        {
            Raiz = EliminarNodoPredecesor(Raiz, valor);
        }

        private NodoBinario EliminarNodoPredecesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return null;
            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoPredecesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoPredecesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null)
                {
                    NodoBinario predecesor = nodo.Izq;
                    while (predecesor.Der != null)
                    {
                        predecesor = predecesor.Der;
                    }
                    nodo.Dato = predecesor.Dato;
                    nodo.Izq = EliminarNodoPredecesor(nodo.Izq, predecesor.Dato);
                }
                else
                {
                    return nodo.Der;
                }
            }
            return nodo;
        }

        public void EliminarNodoSucesor(int valor)
        {
            Raiz = EliminarNodoSucesor(Raiz, valor);
        }

        private NodoBinario EliminarNodoSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return null;
            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoSucesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoSucesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Der != null)
                {
                    NodoBinario sucesor = nodo.Der;
                    while (sucesor.Izq != null)
                    {
                        sucesor = sucesor.Izq;
                    }
                    nodo.Dato = sucesor.Dato;
                    nodo.Der = EliminarNodoSucesor(nodo.Der, sucesor.Dato);
                }
                else
                {
                    return nodo.Izq;
                }
            }
            return nodo;
        }

        public void RecorrerPorNiveles()
        {
            if (Raiz == null) return;

            Queue<NodoBinario> queue = new Queue<NodoBinario>();
            queue.Enqueue(Raiz);

            while (queue.Count > 0)
            {
                NodoBinario nodo = queue.Dequeue();
                strRecorrido += nodo.Dato + ", ";

                if (nodo.Izq != null) queue.Enqueue(nodo.Izq);
                if (nodo.Der != null) queue.Enqueue(nodo.Der);
            }
        }

        public int ObtenerAltura(NodoBinario nodo)
        {
            if (nodo == null) return -1; // Altura de un árbol vacío es -1
            return Math.Max(ObtenerAltura(nodo.Izq), ObtenerAltura(nodo.Der)) + 1;
        }

        public int CantidadHojas(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            if (nodo.Izq == null && nodo.Der == null) return 1;
            return CantidadHojas(nodo.Izq) + CantidadHojas(nodo.Der);
        }

        public int CantidadNodos(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            return 1 + CantidadNodos(nodo.Izq) + CantidadNodos(nodo.Der);
        }

        public bool EsArbolBinarioCompleto(NodoBinario nodo, int index, int numberNodes)
        {
            if (nodo == null) return true;
            if (index >= numberNodes) return false;
            return EsArbolBinarioCompleto(nodo.Izq, 2 * index + 1, numberNodes) &&
                   EsArbolBinarioCompleto(nodo.Der, 2 * index + 2, numberNodes);
        }

        public bool EsArbolBinarioLleno(NodoBinario nodo)
        {
            if (nodo == null) return true;
            if ((nodo.Izq == null && nodo.Der != null) || (nodo.Izq != null && nodo.Der == null))
                return false;
            return EsArbolBinarioLleno(nodo.Izq) && EsArbolBinarioLleno(nodo.Der);
        }
    

    public bool Busqueda(int valor)
            {
            return busqueda(Raiz, valor);
        }

        private bool busqueda(NodoBinario nodo, int valor)
        {
            if (nodo == null) return false;

            if (nodo.Dato == valor)
            {
                return true;
            }

            else if (valor < nodo.Dato)
            {
                return busqueda(nodo.Izq, valor);
            }
            else
            {
                return busqueda(nodo.Der, valor);
            }
        }

        public void MostrarBuqueda(int valor)
        {
            bool encontrado = Busqueda(valor);
            if (encontrado)
            {
                MessageBox.Show($"El {valor} SI se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show($"El {valor} NO se encuentra en el arbol");
            }
        }
    }
}
