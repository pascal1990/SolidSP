using System;

namespace ConsoleSingleResp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.afficheBienvenue();

            // Creation d'un Utilisateur
            User NouveauUtilisateur = EntrerUser.CapturerUtilisateur();

            // Validation d'un Utilisateur
            bool isValite = ValidateUser.isValiteUser(NouveauUtilisateur);
            if (isValite== false)
            {
                Console.ReadLine();
                return;
            }
            else
            {
                //Creation du Compte
                CreationCompte.CreationUser(NouveauUtilisateur);
            }



            Console.ReadLine();

        }
    }
}
