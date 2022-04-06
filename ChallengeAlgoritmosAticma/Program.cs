using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAlgoritmosAticma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Opciones();

            // ordeno el arreglo que recibo por parametro, de mayor a menor y lo devuelvo ordenado
            int[] OrdenarAsc(int[] arreglo)
            {
                Array.Sort(arreglo);
                /* tambien se puede hacer de la siguiente forma
                recorro el arreglo preguntando si un numero es mayor que la siguiente posicion
                en caso de serlo le intercambio posicion y lo comparo con el siguiente hasta que sea falso
                lo hago desde 0 hasta el ultimo menos 1, la cantidad de veces segun indices tenga el array
                menos 1*/
                
                /*for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4 - i; j++)
                    {
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            int aux;
                            aux = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[(j + 1)] = aux;
                        }
                    }
                }*/
                return arreglo;
            }
            // ordeno el arreglo que recibo por parametro, de mayor a menor y lo devuelvo ordenado
            int[] OrdenarDesc(int[] arreglo)
            {
                Array.Sort(arreglo);
                Array.Reverse(arreglo);
                return arreglo;
            }

            //recorro el arreglo recibido comparando los valores y si hay repetido lo muestro
            //cuento cuantos repetidos hay y lo devuelvo
            int Repetido(int[] arreglo)
            {
                int cont = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    int aux = arreglo[i];
                    int x = i + 1;                    
                    for(int y = x; y < arreglo.Length; y++)
                    {
                        if(arreglo[y] == aux)
                        {
                            Console.WriteLine("El numero " + aux + " está repetido");
                            cont ++;
                        }
                    }
                }
                return cont;
            }

            //muestra el arreglo recibido
            void MostrarArreglo(int[] arreglo)
            {
                Console.WriteLine("La lista ordenada es la siguiente:");
                foreach (int i in arreglo)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }

            //recibo los numeros, devuelvo verdadero o falso segun si cumple
            bool Secuencia(int a, int b, int c)
            {
                if(a%2==0 && b%2==0 && c % 2 != 0) { return true; }
                else { return false; }
            }

            //pido que el usuario ingrese un valor y segun, voy al case correspondiente
            void Opciones()
            {
                Console.WriteLine("Ingrese el numero de ejercicio a testear");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ejercicio 1");
                            Console.WriteLine("Deberá ingresar un rango de números");
                            Console.WriteLine("Ingrese el primer número y presione Enter");
                            int a = Convert.ToInt32(Console.ReadLine()); //Leo el numero y lo asigno a una variable
                            Console.WriteLine("Ingrese el segundo numero y presione Enter");
                            int b = Convert.ToInt32(Console.ReadLine()); //Leo el numero y lo asigno a una variable
                            int divisores = 0; //Creo una variable divisores para saber por cuantos divisores se divide el numero

                            while (a <= b) //Recorro desde el primer numero ingresado hasta el segundo numero ingresado
                            {
                                for (int i = 1; i <= a; i++) //Recorro desde 1 hasta el numero a consultar
                                {
                                    if (a % i == 0) //Condicion si es divisible por i
                                    {
                                        divisores++; //incremento divisores
                                    }
                                    if (divisores > 2) //si tiene mas de dos divisores no es primo, salto y paso al siguiente numero
                                    {
                                        Console.WriteLine(a + " No es primo");
                                        break;
                                    }
                                }
                                if (divisores == 2) //Si tiene dos divisores es primo
                                {
                                    Console.WriteLine(a + " Es un número primo"); //Imprimo el numero por pantalla
                                }

                                divisores = 0; //vuelvo a poner en divisores en 0, no importa si era primo o no
                                a++; //Incremento el numero a consultar
                            }

                            Console.ReadKey();
                            Opciones();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ejercicio 2");
                            var arreglo = new int[5]; //Declaro un arreglo de enteros con 5 lugares
                            int x = 0;
                            int suma = 0; //Declaro dos variables int que voy a usar
                            Console.WriteLine("Ingrese 5 números");
                            while (x < 5)
                            {
                                arreglo[x] = Convert.ToInt32(Console.ReadLine()); //Leo los numeros ingresados y lo asigno del 0 al 4 en el arreglo
                                x++; //aumento el contador
                            }
                            Console.WriteLine();
                            foreach (int i in arreglo) // Para cada elemento del arreglo
                            {
                                suma += i; //Sumo el elemento del arreglo a suma
                                Console.WriteLine(arreglo[x - 1]); //Escribo en consola del ultimo elemento al primero
                                x--; //resto el contador
                            }
                            Console.WriteLine("La suma total de los números ingresados es: " + suma);
                            Console.ReadLine();
                            Console.WriteLine("Si quiere ver la lista de numeros ordenados de menor a mayor ingrese 1");
                            Console.WriteLine("Si quiere ver la lista de numeros ordenados de mayor a menor ingrese 2");
                            Console.WriteLine("Si quiere ver si hay numeros repetidos ingrese 3");

                            //Leo la opcion elegida, la asigno a un int y segun, voy al case que corresponde

                            int aux = Convert.ToInt32(Console.ReadLine());
                            switch (aux)
                            {
                                case 1:
                                    { //llamo al metodo y le paso el arreglo
                                        var i = OrdenarAsc(arreglo);
                                        MostrarArreglo(i);
                                        break;
                                    }
                                case 2:
                                    { //llamo al metodo y le paso el arreglo
                                        var i = OrdenarDesc(arreglo);
                                        MostrarArreglo(i);
                                        break;
                                    }
                                case 3:
                                    { //llamo al metodo y le paso el arreglo
                                        //recibo la cantidad de repetidos y lo muestro
                                        int cont = Repetido(arreglo);
                                        Console.WriteLine("Tiene: " + cont + " numeros repetidos");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Para testear el ejercicio 3 debe testear el ejercicio 2");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            //creo un diccionario con key que va a ser p,a o t y el value que es el jugador
                            //1 o 2. 
                            Dictionary<string,int> dic = new Dictionary<string,int>();
                            Console.WriteLine("Ejercicio 4");
                            Console.WriteLine("Jugador 1, ingrese Piedra(p), Papel(a) o Tijera(t)");
                            dic.Add(Console.ReadLine(),1);
                            Console.WriteLine("Jugador 2, ingrese Piedra(p), Papel(a) o Tijera(t)");
                            //uso try-catch por si la key del jugador 2 es igual al 1 para controlar la excepcion
                            try
                            {
                                dic.Add(Console.ReadLine(), 2);
                            }
                            catch
                            {
                                Console.WriteLine("Empate");
                                Opciones();
                            }
                            
                            //si se cumple alguna de estas condiciones hay un ganador
                            if(dic.ContainsKey("p") && dic.ContainsKey("t"))
                            {
                                Console.WriteLine("El ganador es el jugador " + dic["p"]);
                            }
                            else if(dic.ContainsKey("p") && dic.ContainsKey("a"))
                            {
                                Console.WriteLine("El ganador es el jugador " + dic["a"]);
                            }
                            else if(dic.ContainsKey("t") && dic.ContainsKey("a"))
                            {
                                Console.WriteLine("El ganador es el jugador " + dic["t"]);
                            }
                            dic.Clear(); //limpio el diccionario por las dudas
                            break;
                        }
                    case 5:
                        {
                            //declaro variables, asigno valor por consola
                            string nombre;
                            int edad;
                            int salario;
                            Console.WriteLine("Ingrese su nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese su edad");
                            edad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese su salario");
                            salario = Convert.ToInt32(Console.ReadLine());
                            
                            //segun la condicion de edad muestra el salario correspondiente
                            if(edad < 16)
                            {
                                Console.WriteLine("No tiene edad para trabajar");
                            }
                            else if(edad >18 && edad < 51)
                            {
                                Console.WriteLine("El salario de " + nombre + " ahora es: " + salario * 1.05);
                                Console.ReadKey();
                            }
                            else if (edad >50 && edad < 61)
                            {
                                Console.WriteLine("Su salario ahora es: " + salario * 1.1);
                                Console.ReadKey();
                            }
                            else if (edad > 60)
                            {
                                Console.WriteLine("Su salario ahora es: " + salario * 1.15);
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 6:
                        {
                            //instancio clase random y variables int
                            Random random = new Random();
                            int cont = 0;
                            int a,b, c;

                            //metodo para asignar valores aleatorios a las variables y contar los intentos
                            void Randomear()
                            {
                                a = random.Next(0, 1000);
                                b = random.Next(0, 1000);
                                c = random.Next(0, 1000);
                                cont ++;
                            }

                            //ejecuto primer random y luego mientras no se de la condicion pido al usuario
                            //que siga intentando hasta que de exito
                            Randomear();
                            while(!Secuencia(a, b, c))
                            {
                                Console.WriteLine("No se consiguio par, par, impar. Oprima una tecla para reintentar");
                                Console.ReadKey();
                                Console.WriteLine();
                                Randomear();
                            }
                            
                                Console.WriteLine("Se consiguio par, par, impar: {0}, {1}, {2}",a,b,c);
                                Console.WriteLine("La cantidad de intentos fue: " + cont);
                            
                            break;
                        }

                }
                Opciones(); // vuelvo a opciones para seguir usando el programa y que no se cierre
            }

        }
    }
}

