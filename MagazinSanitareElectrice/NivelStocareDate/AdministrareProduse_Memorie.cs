using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    
    public class AdministrareProduse_Memorie
    {
        private const int NR_MAX_PRODUSE = 100;
        private Produs[] produse;
        private int nrProduse;

        public AdministrareProduse_Memorie()
        {
            produse = new Produs[NR_MAX_PRODUSE];
            nrProduse = 0;
        }

        public void AdaugaProdus(Produs produs)
        {
            if (nrProduse < NR_MAX_PRODUSE)
            {
                produse[nrProduse] = produs;
                nrProduse++;
            }
            else
            {
                Console.WriteLine("Nu se mai pot adăuga produse, stoc maxim atins!");
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            nrProduse = this.nrProduse;
            return produse;
        }

        public Produs CautaProdus(int idProdus)
        {
            foreach (var produs in produse)
            {
                if (produs != null && produs.IdProdus == idProdus)
                {
                    return produs;
                }
            }
            return null;
        }

        public void StergeProdus(int idProdus)
        {
            for (int i = 0; i < nrProduse; i++)
            {
                if (produse[i].IdProdus == idProdus)
                {
                    for (int j = i; j < nrProduse - 1; j++)
                    {
                        produse[j] = produse[j + 1];
                    }
                    produse[nrProduse - 1] = null;
                    nrProduse--;
                    Console.WriteLine("Produs șters cu succes!");
                    return;
                }
            }
            Console.WriteLine("Produsul nu a fost găsit!");
        }

        public void AfiseazaProduse()
        {
            throw new NotImplementedException();
        }

        public void CreareListaProiect()
        {
            throw new NotImplementedException();
        }
    }
}
