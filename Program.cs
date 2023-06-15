using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MetodosStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LongitudCadena("“Estamos creando, estamos soñando…..!"));
            DesmenuzaCadena("Programando…. Ando…");
            Console.WriteLine(InvertirTexto("hola amigos !!!"));
            Console.WriteLine(EliminaBlancos("Mi mundo, la programación de computadores…."));

            Console.WriteLine(  "Mi mundo, la programación de computadores….".Replace(" ", "")  );

            CuentaVocalesConsonantes("En pandemia por un murciélago….");

            DivideConcatena("Si no duele, no te estas esforzando…", ",");
            MayusculasMinusculas("Seguimos Programando…");
            Console.WriteLine(ComparaCadenas("JavaScript", "JavaScript"));
            Console.WriteLine(ReemplazaE("Le ezefete Ene bejebe cede meñene e le mer selede pere lever le felde enerenjede"));
            CodigoASCII("ABCD abcd");
            CuentaCaracteres("Hola, soy DIEGO TREJO, y soy programador desde el 2021.");
            Console.ReadKey();
        }

        /*
         * Tarea 01: Muestra la longitud del texto: “Estamos creando, estamos soñando…..!”
         */

        public static int LongitudCadena(string msg)
        {
            return msg.Length;
        }

        /*
         * Tarea 02: Desmenuza el String “Programando…. Ando…” mostrándolo por pantalla carácter a carácter.
         */
        public static void DesmenuzaCadena(string txt)
        { 
            for(int i=0;  i < txt.Length; i++)
            {
                Console.Write( txt[i] + " " );
            }
            Console.WriteLine();
        }

        /*
         * Tarea 03: Invertir el texto: “Anita lava la tina”
         */
        public static string InvertirTexto(string texto)
        {
            string inverso = "";
            for (int i = texto.Length - 1; i >= 0; i--)  // total de caracteres --> 0
            { 
                inverso += texto[i];
            }

            return inverso;
        }

        /*
         * Tarea 04: Elimina los espacios del texto: “Mi mundo, la programación de computadores….”
         */
        public static string EliminaBlancos(string texto)
        {
            string txt = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                { 
                    txt += texto[i];
                }
            }
            return txt;

            //return texto.Replace(" ", "");
        }

        /*
         * Tarea 05: Cuenta las vocales y las consonantes del String “En pandemia por un murciélago….”. 
         * ¡OJO CON LOS ESPACIOS!
         */

        public static void CuentaVocalesConsonantes(string texto)
        {
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
            string consonantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            int qtyVocales = 0, qtyConsonantes = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (vocales.Contains(texto[i]))
                    qtyVocales++;

                if (consonantes.Contains(texto[i]))
                    qtyConsonantes++;
            }
            Console.WriteLine("cantidad vocales = " + qtyVocales);
            Console.WriteLine("cantidad consonantes = " +  qtyConsonantes);
        }

        /*
         * Tarea 06: Divide la cadena de texto “Si no duele, no te estas esforzando…” 
         * en dos partes “Si no duele,” y “no te estas esforzando…”. 
         * Para posteriormente concaténalas y mostrarlas de nuevo.
         */

        public static void DivideConcatena(string texto, string divisor)
        {
            // string[] partes = texto.Split(',');   // se necesita conocer atrrays
            string parte1 = "", parte2 = "";
            int posicion = 0;

            posicion = texto.IndexOf(divisor);  // encuentra la primera posicion del divisor

            parte1 = texto.Substring(0, posicion) + divisor;
            Console.WriteLine(parte1);

            parte2 = texto.Substring(posicion+1);
            Console.WriteLine(parte2);

            texto = parte1 + parte2;
            Console.WriteLine(texto);
        }

        /*
         * Tarea 07: Transforma la cadena de texto “seguimos programando…” a mayúsculas. 
         * Guarda el valor en la variable y posteriormente conviértela nuevamente a minúsculas.
         */
        public static void MayusculasMinusculas(string texto)
        { 
            string mayusculas = texto.ToUpper();
            Console.WriteLine(mayusculas);

            string minusculas = mayusculas.ToLower();
            Console.WriteLine(minusculas);
        }

        /*
         * Tarea 08: Compara si el String “Java” es igual que el String “JavaScript”.
         */
        public static bool ComparaCadenas(string texto1, string texto2)
        {
            //return texto1 == texto2;
            //return texto1.Equals(texto2);
            if (texto1.Length == texto2.Length)
            {
                for (int i = 0; i < texto1.Length; i++)
                { 
                    if (texto1[i] != texto2[i])
                        return false;
                }
                return true;
            }
            else
                return false;
        }

        /*
         * Tarea 09: Sobre la cadena de texto “Le ezefete Ene bejebe cede meñene e le mer 
         * selede pere lever le felde enerenjede”, sustituye/reemplaza todas las 
         * vocales e por la vocal a y mire su resultado.
         */
        public static string ReemplazaE(string texto)
        {
            return texto.Replace("e", "a").Replace("E", "A");
        }

        /*
         * Tarea 10: Transforma los caracteres del String: “ABCD abcd” a código ASCII e imprimelos en pantalla.
         */
        public static void CodigoASCII(string texto)
        { 
            for(int i= 0; i < texto.Length; i++)
            {
                // use de CAST, el INT de un CHAR representa el codigo ASCII
                Console.WriteLine(texto[i] + "   " + (int)(char)texto[i]);   
            }
        }

        /*
         * Tarea 11: Escribir un método, que dado un objeto de la clase String 
         * cuente diferentes tipos de caracteres. En particular, el método deberá 
         * imprimir el número de letras, dígitos y espacios en blanco de la cadena. 
         * Intenta hacer un programa que escriba el conteo (por ejemplo) de 
         * la cadena. “Hola, soy <<Aquí tu nombre>>, y soy programador desde el 2021…”.
         */
        public static void CuentaCaracteres(string texto)
        {
            string letras = "aeiouAEIOUáéíóúÁÉÍÓÚbcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZñÑ";
            string digitos = "0123456789";
            string especiales = " .,!";
             
            int qtyLetras = 0, qtyDigitos = 0, qtyEspeciales = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (letras.Contains(texto[i]))
                    qtyLetras++;

                if (digitos.Contains(texto[i]))
                    qtyDigitos++;

                if (especiales.Contains(texto[i]))
                    qtyEspeciales++;    
            }
            Console.WriteLine("cantidad letras = " + qtyLetras);
            Console.WriteLine("cantidad dígitos = " + qtyDigitos);
            Console.WriteLine("cantidad especiales = " + qtyEspeciales);
        }
    }

}
