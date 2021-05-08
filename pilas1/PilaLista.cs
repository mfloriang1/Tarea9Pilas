using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pilas1.clases
{
    class PilaLista
    {

        private int cima;
        private List<Object> ListaPila;

        public PilaLista()
        {
            cima = -1; //condicion de pila vacía
            ListaPila = new List<Object>();
        }

        public void insertar(Object elemento)
        {
            cima++;
            ListaPila.Add(elemento);

        }

        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacía");
            }
            aux = ListaPila.ElementAt(cima);
            ListaPila.RemoveAt(cima);
            cima--;
            return aux;

        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacía");
            }
            return ListaPila.ElementAt(cima);


        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarpila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }

}

