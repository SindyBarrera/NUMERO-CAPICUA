using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        //Constructor que es el que va a crear la cola
        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        }


        public bool colaVacia()
        {
            return frente > fin;
        }
        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

        //Oeraciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if(!colaLlena())
            {
                listaCola[++fin] = elemento;
                
            }else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //Quitar elemento de la cola
        public Object quitar()
        {
            if(!colaVacia())
            {
                return listaCola[frente++];

            }else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];

            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }





    }//end class
}
