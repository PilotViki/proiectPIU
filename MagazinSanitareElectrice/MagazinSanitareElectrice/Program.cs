using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using NivelStocareDate;

namespace EvidentaProduse
{
    class Program
    {
        static void Main()
        {
            int idProdus=0;
            Produs produs= new Produs(0,"țeava",0,"10cm") ;
            AdministrareProduse_Memorie adminProduse = new AdministrareProduse_Memorie();
            string optiune;

            do
            {
                AfiseazaMeniu();
                optiune = Console.ReadLine();

                switch (optiune)
                {   
                    case "1": adminProduse.AdaugaProdus(produs); break;
                    case "2": adminProduse.AfiseazaProduse(); break;
                    case "3": adminProduse.CautaProdus(idProdus); break;
                    case "4": adminProduse.StergeProdus(idProdus); break;
                    case "5": adminProduse.CreareListaProiect(); break;
                    case "6": Console.WriteLine("Ieșire din aplicație."); return;
                    default: Console.WriteLine("Opțiune invalidă. Alegeți din nou."); break;
                }
            } while (optiune != "6");
        }

        static void AfiseazaMeniu()
        {
            Console.WriteLine("\n===== Meniu Magazin =====");
            Console.WriteLine("1. Adăugare produs");
            Console.WriteLine("2. Afișare produse");
            Console.WriteLine("3. Căutare produs după ID");
            Console.WriteLine("4. Ștergere produs");
            Console.WriteLine("5. Creare listă pentru proiect");
            Console.WriteLine("6. Ieșire");
            Console.Write("Alege o opțiune: ");
        }
    }
}
