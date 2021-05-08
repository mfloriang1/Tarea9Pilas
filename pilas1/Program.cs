using pilas1.clases;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace pilas1
{
    class Program
    {

        private static object normalizationForm;

        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;
            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PilaLineal();//crea pila (push)
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());

                    if (x != -1)
                    {

                        pila.insertar(x);
                    }

                } while (x != CLAVE);

                Console.WriteLine("Estos son los elementos de la pila");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }
                pila.insertar(900);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error=" + error.Message);
            }
        }

        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
            PilaListaSimple listaEnla = new PilaListaSimple();



            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                //creamos la pila con los chars


                string reemplazada = System.Text.RegularExpressions.Regex.Replace(pal, @"\s", "");
                string convertida = reemplazada.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9]");//método
                string textonoramlizado = convertida.Normalize(NormalizationForm.FormD);
                string textoSA = reg.Replace(textonoramlizado, "");



                for (int i = 0; i < textoSA.Length;)
                {
                    Char c;
                    c = textoSA[i++];//textoSA variable que evaluara si es polindromo o no
                    listaEnla.insertar(c);
                    //pilaChar.IsWhiteSpace(c);


                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }

        static void EjemploPilaLista()
        {
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            int pau;
            pau = 0;
        }


        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //ejemploPilaLineal();
            palindromo();
            //EjemploPilaLista();
        }
    }

    internal class PilaListaSimple
    {
        internal void insertar(char c)
        {
            throw new NotImplementedException();
        }
    }
}

