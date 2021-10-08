using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione vettore 
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //Richiamo il metodo ordina
            ordina(vettore);
            //Stampo a video l'array
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        static void ordina (int[] vettore)
        {
            //metodo per l'ordinamento dell'array
            Array.Sort(vettore);
        }

     
    }
}
