using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSingleResp
{
    public static class CreationCompte
    {
        public static void CreationUser(User user)
        {
            Console.WriteLine($"Votre Compte a ete cree avec pour Nom Utilisateur : " +
                                   $"{user.NomUtilisateur} et Mot de Passe : " +
                                   $"{user.MotPasse}");
        }
    }
}
