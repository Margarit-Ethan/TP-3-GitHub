using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_GitHub
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre code:");

            Compte Compte1 = new Compte
            {
                ID = 1,
                Nom = "Palpatine",
                Prenom = "Sidious",
                Montant = 2003,
                Code = int.Parse(Console.ReadLine())

            };

            if (Compte1.Code == 0066) {

                Console.WriteLine("Tapez 1 pour consulter le solde, tapez 2 pour ajouter de l'argent, tapez 3 pour retirer de l'argent, tapez autre chose pour quitter");

                int.TryParse(Console.ReadLine(), out int menu);

                if (menu == 1)
                {
                    Compte1.ConsulterSolde();
                } 
                else if (menu == 2)
                {
                    Compte1.AjouterArgent(int.Parse(Console.ReadLine()));
                }
                else if (menu == 3)
                {
                    Compte1.RetirerArgent(int.Parse(Console.ReadLine()));
                } else
                {
                    Console.WriteLine("Vous quittez le menu.");
                }

            } else

            {
                Console.WriteLine("Le code saisie n'est pas reconnue.");
            }

            
        }

    }
}
