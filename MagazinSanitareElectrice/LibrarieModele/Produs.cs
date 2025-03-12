using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Produs
    {
        // Proprietăți
        public int IdProdus { get; set; } // ID PRODD
        public string Nume { get; set; }
        public double Pret { get; set; }
        public string Dimensiuni { get; set; } // Ex.: "5m"

        // Constructor implicit
        public Produs()
        {
            Nume = string.Empty;
            Dimensiuni = string.Empty;
        }

        // Constructor cu parametri
        public Produs(int idProdus, string nume, double pret, string dimensiuni)
        {
            IdProdus = idProdus;
            Nume = nume;
            Pret = pret;
            Dimensiuni = dimensiuni;
        }

        // afișare informații produs
        public string Info()
        {
            return $"Id: {IdProdus} | Nume: {Nume} | Pret: {Pret} RON | Dimensiuni: {Dimensiuni}";
        }
    }
}
