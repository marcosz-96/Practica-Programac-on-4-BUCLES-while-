using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Programacíon_4__BUCLES__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 de la Guía 4: Números correlativos desde el número ingresado

            /*int numIncial;
            int cont = 0;

            Console.Write("Ingrese un número positivo: ");
            numIncial = int.Parse(Console.ReadLine());

            while (numIncial > 0 && cont <= numIncial ) 
            {
                Console.WriteLine(" Los siguientes números son: " + cont);
                cont++;
            }*/


            //Ejercicio 2 de la Guía 4: Carga, Suma y Promedio de valores

            /*int cont1 = 1;
            int numIngresado = 0;
            int suma = 0;
            int promedio = 0; 

            while (cont1 <= 10)
            {
                Console.WriteLine("Ingrese un número");
                numIngresado = int.Parse(Console.ReadLine());
                suma = suma + numIngresado;
                promedio = suma / 10;

                cont1++;
            }
            Console.WriteLine("La suma de los valores es igual a: " + suma);
            Console.WriteLine("El promedio es igual a: " + promedio);
            Console.WriteLine("Fin de la operación!");*/


            //Ejercicio 3 de la Guía 4: Fábrica de perfiles

            /*int piezas = 0;
            double longitud = 0; 
            int piezasAptas = 0;
            int cant = 0; 
            

            Console.Write("Ingrese la cantidad de piezas a procesar: ");
            piezas = int.Parse(Console.ReadLine());

            while (cant < piezas)
            {
                Console.Write("Ingrese la longitud de las piezas: ");
                longitud = double.Parse(Console.ReadLine());

                if (longitud >= 120 && longitud <= 130)
                {
                    piezasAptas++;
                }
                cant++;
            }

            Console.WriteLine("La cantidad de piezas aptas son:  " +piezasAptas);*/


            //Ejercicio 4 de la Guía 4: Notas de alumnos

            /*int notas = 0;
            double notasBajas = 0; 
            int notasAltas = 0;
            int mas = 0; 
            

            while (mas < 10)
            {
                Console.Write("Ingrese las notas de los alumnos: ");
                notas = int.Parse(Console.ReadLine());
                mas++;

                if (notas >= 7)
                {
                    notasAltas++;
                }
                else
                {
                    notasBajas++;
                }
            }

            Console.WriteLine("Las Notas a partir de 7 son:  " +notasAltas);
            Console.WriteLine("Las Notas menores a 7 son: " +notasBajas);*/


            //Ejercicio 5 de la Guía 4: Promedios de altura

            /*double altura = 0;
            double promAlt = 0;
            int contAlt = 0;
            double sumAlt = 0;
            int cantAltura = 0;


            Console.Write("Escriba la cantidad de estaturas que quiere promediar: ");
            cantAltura = int.Parse(Console.ReadLine());

            while (contAlt < cantAltura)
            {
                Console.Write("Escriba la estaturas a promediar: ");
                altura = double.Parse(Console.ReadLine());
                sumAlt = sumAlt + altura;
                promAlt = sumAlt / cantAltura;

                contAlt++;
            }
            Console.WriteLine("El promedio de estaturas es: " +promAlt);*/



            //Ejercicio 6 de la Guía 4: Lectura de sueldos

            /*int empleado = 0;
            double sueldos = 0;
            double gastosEmpresa = 0;
            double sueldosAltos = 0;
            double sueldosBajos = 0;
            int contBucle = 0;

            Console.Write("Ingrese la cantidad de empleados: ");
            empleado = int.Parse(Console.ReadLine());

            while (contBucle < empleado)
            {
                Console.Write("Ingrese el sueldo: ");
                sueldos = Convert.ToDouble(Console.ReadLine());

                if (sueldos >= 100 && sueldos <= 300)
                {
                    sueldosBajos++;
                    gastosEmpresa = gastosEmpresa + sueldos;
                    contBucle++;
                }
                else if (sueldos > 300 && sueldos <= 500)
                {
                    sueldosAltos++;
                    gastosEmpresa = gastosEmpresa + sueldos;
                    contBucle++;
                }
                else
                {
                    Console.WriteLine("Sueldo Ingresado no es válido");
                }


            }
            Console.WriteLine($"Cantidad de empleados con sueldos bajos son: {sueldosBajos}");
            Console.WriteLine($"Cantidad de empleados con sueldos altos son: {sueldosAltos}");
            Console.WriteLine($"Los gatos de la empresa son de: {gastosEmpresa}");*/



            //Ejercicio 7 de la Guía 4: Términos de la serie

            /*int nNum = 0;
            int nCont = 0;

            Console.WriteLine("Se muestran los resultados de los términos de series");

            while (nCont < 10)
            {
                Console.WriteLine(nNum);
                nNum += 11;
                nCont++;
            }*/



            //Ejercicio 8 de la Guía 4: Múltiplos de 8 desde el 0 al 500

            /*int xNum = 0;
            
            Console.WriteLine("Se muestran los números múltiplos de 8, desde el 0 al 500");

            while (xNum <= 500)
            {
                if ( xNum % 8 == 0)
                {
                    Console.WriteLine(xNum);
                }
                xNum++;
            }

            */


            //Ejercicio 9 de la Guía 4: Listas de valores

            /*int lista1;
            int lista2;
            double listaMayor1 = 0;
            double listaMaryor2 = 0;
            int cont = 0;

            Console.WriteLine("Escriba los valores de las listas");
            while (cont < 30)
            {
                if (cont < 15)
                {
                    Console.Write("Valores de la primer lista: ");
                    lista1 = int.Parse(Console.ReadLine());
                    listaMayor1 = listaMayor1 + lista1;
                    cont++;
                }
                else if (cont < 30 && cont >= 15)
                {
                    Console.Write("Valores de la segunda lista: ");
                    lista2 = int.Parse(Console.ReadLine());
                    listaMaryor2 = listaMaryor2 + lista2; 
                    cont++;
                }

            }

            Console.WriteLine($"La suma de los valores de la primer lista es: {listaMayor1}");
            Console.WriteLine($"La suma de los valores de la segunda lista es: {listaMaryor2}");

            if (listaMayor1 > listaMaryor2)
            {
                Console.WriteLine("La primer lista tiene mayor valor total que la segunda");
            }
            else if (listaMaryor2 > listaMayor1)
            {
                Console.WriteLine("La segunda lista tiene mayor valor total que la primera");
            }
            else if (listaMayor1 == listaMaryor2)
            {
                Console.WriteLine("Las listas tienen el mismo valor total");
            }
            */


            //Ejercicio 10 de la Guía 4: Clasificación de números pares e impares

            /*int cNum = 0;
            int num = 0;
            int numPar = 0;
            int numImp = 0;
            int cont = 0;

            Console.WriteLine("Ingrese la cantidad de números a clasificar");
            cNum = int.Parse(Console.ReadLine());

            while (cont < cNum)
            {
                Console.Write("Ingrese el número: ");
                num = int.Parse(Console.ReadLine());

                if (num %2 == 0)
                {
                    numPar++;
                }
                else
                {
                    numImp++;
                }
                cont++;
            }

            Console.WriteLine($"La lista de números ingresados tienen {numPar} números pares y {numImp} números impares");
            */
        }

    }
}
