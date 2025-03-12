using System;
using System.Collections.Generic;
using System.Linq;

namespace MagazinSanitareElectrice.EvidentaProduse
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class AdministrareProduse_Memorie
    {
        private List<Product> produse;

        public AdministrareProduse_Memorie()
        {
            produse = new List<Product>();
        }

        public void AdaugaProdus()
        {
            Console.Write("Introduceți ID-ul produsului: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Introduceți numele produsului: ");
            string name = Console.ReadLine();
            Console.Write("Introduceți prețul produsului: ");
            double price = double.Parse(Console.ReadLine());

            produse.Add(new Product { Id = id, Name = name, Price = price });
            Console.WriteLine("Produsul a fost adăugat cu succes!");
        }

        public void AfiseazaProduse()
        {
            if (produse.Count == 0)
            {
                Console.WriteLine("Nu există produse înregistrate.");
                return;
            }

            Console.WriteLine("\nLista produselor:");
            foreach (var produs in produse)
            {
                Console.WriteLine($"ID: {produs.Id}, Nume: {produs.Name}, Preț: {produs.Price}");
            }
        }

        public void CautaProdus()
        {
            Console.Write("Introduceți ID-ul produsului de căutat: ");
            int id = int.Parse(Console.ReadLine());

            var produs = produse.FirstOrDefault(p => p.Id == id);
            if (produs != null)
            {
                Console.WriteLine($"Produs găsit: ID: {produs.Id}, Nume: {produs.Name}, Preț: {produs.Price}");
            }
            else
            {
                Console.WriteLine("Produsul cu acest ID nu a fost găsit.");
            }
        }

        public void StergeProdus()
        {
            Console.Write("Introduceți ID-ul produsului de șters: ");
            int id = int.Parse(Console.ReadLine());

            var produs = produse.FirstOrDefault(p => p.Id == id);
            if (produs != null)
            {
                produse.Remove(produs);
                Console.WriteLine("Produsul a fost șters cu succes.");
            }
            else
            {
                Console.WriteLine("Produsul cu acest ID nu a fost găsit.");
            }
        }

        public void CreareListaProiect()
        {
            Console.WriteLine("Creare listă proiect... (Funcționalitatea va fi adăugată)");
        }
    }
}

