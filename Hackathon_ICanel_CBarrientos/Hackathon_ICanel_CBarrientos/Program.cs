using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_ICanel_CBarrientos
{
    class Program
    {


        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }


        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" HACKATHON - NIVEL 1");
            Console.WriteLine(" Iván Alexander Canel García - 1301019");
            Console.WriteLine(" Cristian Josué Barrientos Mijangos - ");
            Console.WriteLine("------------------------------------------------\n");

            Console.WriteLine(" Seleccione la opción que desea efectuar: \n 1. Problema 1: Calculadora de sumas y restas en binario, decimal y hexadecimal \n 2. Problema 2: Contador de vocales en una consola \n 3. Problema 3: Sumadora factorial \n 4. Problema 4: Repartidor de porciones");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Problema1();
                    break;
                case 2:
                    Problema2();
                    break;
                case 3:
                    Problema3();
                    break;
                case 4:
                    Problema4();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;

            }
            Console.ReadLine();
        }



        static void Problema1()
        {

            int menu;
            string numero1, numero2, resultadoBinario, resultadoDecimal, resultadoHexadecimal;

            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" CALCULADORA DE SUMAS Y RESTAS EN BINARIO, DECIMAL Y HEXADECIMAL ");
            Console.WriteLine("------------------------------------------------\n");

            Console.WriteLine(" 1. Sumar Decimal ");
            Console.WriteLine(" 2. Restar Decimal ");
            Console.WriteLine(" 3. Sumar Binario ");
            Console.WriteLine(" 4. Restar Binario ");
            Console.WriteLine(" 5. Sumar Hexadecimal ");
            Console.WriteLine(" 6. Restar Hexadecimal \n");

            Console.WriteLine("Ingrese el numero de la opción que desee:");
            menu = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Primer Numero: ");
            numero1 = Console.ReadLine();
            Console.WriteLine("Ingrese el Segundo Numero: ");
            numero2 = Console.ReadLine();
            Console.WriteLine("----------------------------------------");
            switch (menu)
            {
                //Sumar Decimal
                case 1:
                    try
                    {
                        int resultado;
                        resultado = int.Parse(numero1) + int.Parse(numero2);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " + " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");
                        throw;
                    }
                    break;
                //Restar Decimal
                case 2:
                    try
                    {
                        int resultado;
                        resultado = int.Parse(numero1) - int.Parse(numero2);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " - " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");
                        throw;
                    }
                    break;
                //Sumar Binario
                case 3:
                    try
                    {
                        int resultado;
                        resultado = Convert.ToInt32(numero1, 2) + Convert.ToInt32(numero2, 2);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " + " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");
                        throw;
                    }
                    break;
                //Resta Binario
                case 4:
                    try
                    {
                        int resultado;
                        resultado = Convert.ToInt32(numero1, 2) - Convert.ToInt32(numero2, 2);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " - " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");
                        throw;
                    }
                    break;
                //Sumar Hexadecimal 
                case 5:
                    try
                    {
                        int resultado;
                        resultado = Convert.ToInt32(numero1, 16) + Convert.ToInt32(numero2, 16);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " + " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");
                        Console.ReadLine();
                        throw;
                    }
                    break;
                //Restar Hexadecimal
                case 6:
                    try
                    {
                        int resultado;
                        resultado = Convert.ToInt32(numero1, 16) - Convert.ToInt32(numero2, 16);
                        resultadoBinario = Convert.ToString(resultado, 2);
                        resultadoDecimal = Convert.ToString(resultado);
                        resultadoHexadecimal = Convert.ToString(resultado, 16);
                        Console.WriteLine("Operación Realizada:" + numero1 + " - " + numero2);
                        Console.WriteLine("El Resultados Binario es: " + resultadoBinario);
                        Console.WriteLine("El Resultados Decimal es: " + resultadoDecimal);
                        Console.WriteLine("El Resultados Hexadecimal es: " + resultadoHexadecimal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Los datos ingresados son incorrectos :(");

                        throw;
                    }
                    break;
                default:
                    Console.WriteLine("Los datos ingresados son incorrectos :(");
                    Console.ReadLine();
                    break;
            }
            Console.Write("\n");
            Regresar();
        }

        static void Problema3()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" SUMADORA FACTORIAL ");
            Console.WriteLine("------------------------------------------------\n");

            string factorial;
            Console.WriteLine("Ingrese un numero factorial (10!): ");
            factorial = Console.ReadLine();
            if (factorial.Contains("!"))
            {
                int num = Convert.ToInt32(factorial.Substring(0, factorial.Length - 1));
                Console.WriteLine("El resultado es: " + Factorial(num) + "\n");
            }
            else
            {
                Console.WriteLine("Los datos ingresados son incorrectos :(");
                Console.ReadLine();
            }

            Regresar();
        }

        static void Problema2() {
            int vocalA = 0, vocalE = 0, vocalI = 0, vocalO = 0, vocalU = 0;

            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" CONTADOR DE VOCALES DE UNA CADENA ");
            Console.WriteLine("------------------------------------------------\n");

            Console.Write("Ingrese una cadena de texto: ");
            string cadena = Console.ReadLine();

            for (int i = 0; i < cadena.Length; i++) {

                switch (cadena[i]) {
                    case 'a':
                        vocalA += 1;
                        break;

                    case 'e':
                        vocalE += 1;
                        break;

                    case 'i':
                        vocalI += 1;
                        break;

                    case 'o':
                        vocalO += 1;
                        break;

                    case 'u':
                        vocalU += 1;
                        break;

                    case 'A':
                        vocalA += 1;
                        break;

                    case 'E':
                        vocalE += 1;
                        break;

                    case 'I':
                        vocalI += 1;
                        break;

                    case 'O':
                        vocalO += 1;
                        break;

                    case 'U':
                        vocalU += 1;
                        break;
                }
            }
            Console.Write("\nEn la palabra ingresada existen: \n Cantidad de 'a - A': " + vocalA + "\n Cantidad de 'e - E': " + vocalE + "\n Cantidad de 'i - I': " + vocalI + "\n Cantidad de 'o - O': " + vocalO + "\n Cantidad de 'u - U': " + vocalU + "\n");
            Regresar();
        }



        static void Problema4()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" REPARTIDOR DE PORCIONES ");
            Console.WriteLine("------------------------------------------------\n");

            Console.Write("Ingrese la cantidad de amigos: ");
            int cantidad_amigos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de porciones por amigo: ");
            int porciones_amigo = int.Parse(Console.ReadLine());

            int cantidad_total_porciones = cantidad_amigos * porciones_amigo;

            float pasteles = cantidad_total_porciones / 4;

            Console.Write("\n Cantidad de pasteles: " + Math.Ceiling(pasteles) + "\n");

            Regresar();
        }

        static void Regresar() {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Presione una tecla para volver a menú principal");
            Console.WriteLine("------------------------------------------------");
            Console.ReadLine();
            Menu();
        }
    }


}
