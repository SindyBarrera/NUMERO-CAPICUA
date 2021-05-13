using Colas.clases.ColaArreglo;
using Colas.clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        //VALIDAR SI ES UN NUMERO O NO ES UN NUMERO
        private static bool valido(String numero)
        {
            bool sw = true; 
            int i = 0;

            //Hacemos el recorrido
            while (sw && (i < numero.Length))
            {
                Char c;
                c = numero[i++]; //Hacer el recorrido caracter por caracter
                sw = (c >= '0' && c <= '9'); //Sera un true

            }
            return sw; 

        }

        //EVALUAMOS SI EL NUMERO ES CAPICUA
        static void NumCapicuaQueueStack()
        {
            //PROGRAMA CAPICUA
            bool capicua;
            string numero;

            //PilaLista pila = new PilaLista();
            //ColaCircular circula_Cola = new ColaCircular();
            
            Queue cola = new Queue(); //crear un objeto de una Queue
            Stack pila = new Stack();

            try
            {
                capicua = false;

                while (!capicua) //Mientras no sea capicua
                {
                    //Para que se repita mientras el numero sea diferente a valido
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();

                    } while (!valido(numero)); //Pasamos como referencia el numero


                    //Pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        //Hacemos la iteracion sobre cada uno de los caracteres
                        Char c;
                        c = numero[i]; 
                        cola.Enqueue(c); //Insertamos cada caracter en la cola 
                        pila.Push(c); //Insertamos cada caracter en la pila

                        //circula_Cola.insertar(c);
                        //pila.insertar(c);

                    }

                    //Retiramos de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)cola.Dequeue(); //Devolver el objeto al principio de la cola.
                        capicua = d.Equals(pila.Pop()); //compara la igualdad .pop devuelve el objeto en al parte superior de la pila

                        //d = (Char)circula_Cola.quitar();
                        //capicua = d.Equals(pila.quitar()); //compara la igualdad

                     //Mientras sea capicua y la cola no este vacia
                    } while (capicua && cola.Count != 0); //Count Obtiene el número de elementos en la cola
                   

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} SI es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"numero {numero} NO es capicua");
                        Console.WriteLine("intente otro");
                    }

                    // vaciar estructuras
                    //Eliminar todos los objetos de la cola y pila
                    cola.Clear(); 
                    pila.Clear();

                    //circula_Cola.borrarCola(); 
                    //pila.limpiarPila();
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }

        }

        static void Main(string []args)
        {

            NumCapicuaQueueStack();

            //Queue qt = new Queue();
            //qt.Enqueue("hola");
            //qt.Enqueue("esta");
            //qt.Enqueue("es");
            //qt.Enqueue("una");
            //qt.Enqueue("prueba");

            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");

            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");
            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");
            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");
            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");
            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");
            //Console.WriteLine($"Desencolamndo {qt.Dequeue()}");
            //Console.WriteLine($"la cola tiene {qt.Count} elementos ");




        }
    }
}