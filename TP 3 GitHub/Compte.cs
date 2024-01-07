using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_GitHub
{
    public class Compte
    {

        public int ID {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public decimal Montant { get; set; }
        public int Code { get; set; }


        public void ConsulterSolde()
        {
            Console.WriteLine("BANQUE : Solde: " + Montant + " euros");
        }

        public void AjouterArgent(decimal montant)
        {
            Montant += montant;
            Console.WriteLine("BANQUE: + "+ montant + " euros ajoutés au compte de "  + Nom  + Prenom);
        }

        public void RetirerArgent(decimal montant)
        {
            if (Montant >= montant)
            {
                Montant -= montant;
                Console.WriteLine("BANQUE : - " + montant + "euros sur le compte de " + Nom + Prenom);
            }
            else
            {
                Console.WriteLine("BANQUE : Vous ne possédez pas les fonds nécessaires afin d'effectuer un retrait.");
            }
        }

        

    }
}
