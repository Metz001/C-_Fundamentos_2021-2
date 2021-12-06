/*
 * Programa: Hola Mundo
 * 
 * Descripción:
 * ->Éste codigo demuestra la impresión de mensajes básicos en consola usando el método
 * Console.WriteLine() una vez es ejecutado o depurado el programa
 * 
 * Declaramos un par de variables tipo "string" que son cadena de caracteres
*/
using System;


namespace HolaMundo_Class1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido"); //← Invocación sencilla de Console.WriteLine 
                              //↑El mensaje va entre paréntesis y comillas dobles porque es un string o texto
           
            //declaración de una variable
            string mensaje;
            //↑ tipo de varibale + nombre de variable
            mensaje = "Esto es un mensaje";
            //↑ Asignación de valor de variable. Llamamos la varibale por su nombre y la igualamos(=) a lo que queremos
            Console.WriteLine(mensaje + "\n");
            //↑ Impresión en consola de la varibale "mensaje" y salto de línea con el comando "\n"
            string otroMensaje = "Esto es otro mensaje";

            Console.WriteLine(otroMensaje + " de Hola Mundo" + "\n");
            //↑ Impresión en consola de la varibale "otroMensaje" y concatenación (+) con un mensaje que dice:
            //" de hola mundo"
            Console.WriteLine(mensaje + " - " +otroMensaje);
            //Impresión de dos variables
            Console.WriteLine();
           
        }
    }
}
