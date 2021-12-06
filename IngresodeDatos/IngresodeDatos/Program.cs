/*
 * Programa: Ingreso de Datos
 * 
 *Descripción: 
 * ->Este códgio demuestra el funcionamiento básico de la consola
 * usando el método "Readline()", el cual sirve para capturar datos desde dicha consola
 * 
 * También se meustra el cambio de tipo de variable desde string a int, utilizando el 
 * método Convert.ToInt32() y el método Int.Parce()
 * 
 * Se previene de manera básica los errores con las instruciones tr{} - catch{}
 * 
 */
using System;


namespace IngresodeDatos
{
    internal class Program
    {
        static void Main()
        {
            //declaración de las variables que se usarán

            string nombre; 
            //↑variable cadena de texto donde se guardará el nombre del usuario                 
            int edad;
            //↑variable entera donde se guardará la edad del usuario

            Console.WriteLine("Programa para leer datos"); //←Mensaje de presentación
                   
            Console.WriteLine("¿Cual es tu nombre?");//←Mensaje de petición de información, nombre            
            nombre = Console.ReadLine();
            //↑Asignación de la variable "nombre" al valor entregado en consola a través de Console.ReadLine();
            
            Console.WriteLine("¿Cual es tu Apellido?");//←Mensaje de petición de información, apellido
            string apellido = Console.ReadLine();
            //↑Solo como demostración, se asignó el valor de apellido en la misma línea de su declaración

            Console.WriteLine("Hola, un gusto {0} {1}", nombre, apellido);
            //↑Impresión de las variables nombre y apellido

            try//-->Comienzo de la instrucción try - catch
            {
                //Dentro del try{} ponemos las instruciones que queremos que intente hacer el programa

                Console.WriteLine("¿Cuantos años tienes?");//←Mensaje de petición de información, nombre
                edad = Convert.ToInt32(Console.ReadLine());
                //↑Asignación de la variable "edad" y conversión a Int usando Convert.ToInt32()
                //Dentro del paréntesis de Convert.ToInt32() ponemos el método de lectura de línea

                Console.WriteLine("Tienes " + edad + " Años");
                //↑Impresión de la edad

            }
            catch (Exception error) //En caso de haber un error en el try{}, sl código irá directamente al catch{}
            {
                Console.WriteLine("!Ingresaste un dato no numerico"); //←Mensaje de error para el usuiario
                Console.WriteLine("Error: "+ error +"\n\n");
            }
            Console.WriteLine("Programa para hacer operaciones simples \n");

            //Éste seguno uso de try catch es báscamente el mismo
            try//-->Comienzo de la instrucción try - catch sumas
            {
                Console.WriteLine("Sumas, Ingrese dos numeros para Multiplicar");
                Console.WriteLine("Ingrese el primer número");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                //↑declaración y asignación y conversión de variable en una línea
                Console.WriteLine("Ingrese el segundo número");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                //↑declaración y asignación y conversión de variable en una línea
                Console.WriteLine("Ingresaste {0} y {1}", numero1, numero2);
                int resultado = numero1 + numero2;
                //↑declaración de una tercera variable "resultado" donde guardamos la suma
                Console.WriteLine("La suma de los numeros ingresados es de " + resultado);
            }
            catch (Exception error)
            {
                Console.WriteLine("¡Ingresaste un dato no numerico!");
                Console.WriteLine("Error: " + error + "\n");
            }
       
        }
    }
}
