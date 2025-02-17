using System;
using MenuRistorante.Services;

namespace MenuRistorante
{
    class Program
    {
        static void Main(string[] args)
        {
            GestioneOrdine gestioneOrdine = new GestioneOrdine();
            bool continua = true;

            while (continua)
            {
                gestioneOrdine.MostraMenu();
                Console.Write("Inserisci il numero del piatto che vuoi ordinare (11 per il conto): ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int scelta))
                {
                    if (scelta == 11)
                    {
                        gestioneOrdine.StampaConto();
                        continua = false;
                    }
                    else
                    {
                        gestioneOrdine.AggiungiAlCarrello(scelta);
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero da 1 a 11.");
                }
            }
            Console.WriteLine("\nPremi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
