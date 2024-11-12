using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusquedaBase
    {

        private NodoBinario EliminarNodoSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return null;
            if (valor < nodo.Dato)
            {

                public bool busqueda(int valor)
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
                    bool encontrado = busqueda(valor);
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
    }
}