using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSingleResp
{
    public static class Message
    {
        public static void afficheBienvenue()
        {
            Console.WriteLine("Bienvenue Creer votre Compte");
        }

        public static string EntrerUtilisateur = "Entrez Votre nom Utilisateur";

        public static string EntrerMotPasse = "Votre Mot de Passe";

        public static string ErrorNomUtilisateur = "Nom Utilisateur incorrect";

        public static string ErrorMotPasse = "Mot de passe incorrect";

    }
}
