using System;
using System.Collections.Generic;
using MenuRistorante.Models;

namespace MenuRistorante.Services
{
    public class GestioneOrdine
    {
        private List<Cibo> menu;
        private List<Cibo> ordine;
        private const double COSTO_SERVIZIO = 3.00;

        public GestioneOrdine()
        {
            menu = new List<Cibo>
            {
                new Cibo(1, "Coca Cola 150 ml", 2.50),
                new Cibo(2, "Insalata di pollo", 5.20),
                new Cibo(3, "Pizza Margherita", 10.00),
                new Cibo(4, "Pizza 4 Formaggi", 12.50),
                new Cibo(5, "Pz patatine fritte", 3.50),
                new Cibo(6, "Insalata di riso", 8.00),
                new Cibo(7, "Frutta di stagione", 5.00),
                new Cibo(8, "Pizza fritta", 5.00),
                new Cibo(9, "Piadina vegetariana", 6.00),
                new Cibo(10, "Panino Hamburger", 7.90),
            };

            ordine = new List<Cibo>();
        }

        public void MostraMenu()
        {
            Console.WriteLine("\n==============MENU==============");
            foreach (var cibo in menu)
            {
                Console.WriteLine(cibo);
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============\n");
        }

        public void AggiungiAlCarrello(int id)
        {
            Cibo ciboScelto = menu.Find(c => c.Id == id);
            if (ciboScelto != null)
            {
                ordine.Add(ciboScelto);
                Console.WriteLine($"{ciboScelto.Nome} aggiunto al carrello!\n");
            }
            else
            {
                Console.WriteLine("Scelta non valida. Riprova.\n");
            }
        }

        public void StampaConto()
        {
            Console.WriteLine("\n============== CONTO FINALE ==============");
            if (ordine.Count == 0)
            {
                Console.WriteLine("Nessun elemento selezionato.");
                return;
            }

            double totale = 0;
            foreach (var cibo in ordine)
            {
                Console.WriteLine($"{cibo.Nome}: {cibo.Prezzo:F2} euro");
                totale += cibo.Prezzo;
            }

            Console.WriteLine($"\nSubtotale: {totale:F2} euro");
            Console.WriteLine($"Servizio al tavolo: {COSTO_SERVIZIO:F2} euro");
            Console.WriteLine($"Totale da pagare: {(totale + COSTO_SERVIZIO):F2} euro");
            Console.WriteLine("========================================\n");
            Console.WriteLine("Grazie per aver ordinato con noi!");
        }
    }
}
