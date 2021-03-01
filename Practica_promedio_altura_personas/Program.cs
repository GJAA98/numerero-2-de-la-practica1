using System;

namespace Practica_promedio_altura_personas
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Inserte un numero:");
                string valor = Console.ReadLine();
                numeros[i] = float.Parse(valor);
            }
            
            float sumatoria = 0;
            for (int i = 0; i < numeros.Length; i++)
            {                
                sumatoria += numeros[i];
            }
            float media = sumatoria / numeros.Length;

            int masAltas = 0;
            int masBajas = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > media)
                {
                    masAltas++;
                }
                else
                {
                    masBajas++;
                }
            }
            Console.WriteLine("Promedio de altura:" + media);
            Console.WriteLine("Personas mas altas:" + masAltas);
            Console.WriteLine("Personas mas bajas:" + masBajas);
        }
    }
}
