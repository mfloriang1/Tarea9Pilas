using System;
using System.Collections.Generic;
using System.Text;

namespace pilas1.clases
{
    class PilaLineal

    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;

        public PilaLineal()
        {
            cima = -1;// si la pila esta vacia
            ListaPila = new Object[TAMPILA];

        }
        public bool pilaLlena()
        {
            return cima == (TAMPILA - 1);
        }
        // operaciones que modifican  la pila
        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Satack Overflow");

            }
            //incrementar puntero cima e insertamos el elemento
            cima++;
            ListaPila[cima] = elemento;

        }
        public bool pilaVacia()
        {
            return cima == -1;
        }

        // Retorna un tipo char
        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacía no hay datos");
            }
            aux = (char)ListaPila[cima];
            cima--;
            return aux;
        }


        // Extraer elemento de a la pila(pop)

        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La pila está vacía, no se puede sacar");

            }
            //guarda elmentos en la cima
            aux = (int)ListaPila[cima];
            // decrementar el valor de cima y retornar elemento
            cima--;
            return aux;


        }
        public void limpiarPila()
        {
            cima = -1;
        }
        // operaciones de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacía");
            }
            return ListaPila[cima];
        }
    }
}

