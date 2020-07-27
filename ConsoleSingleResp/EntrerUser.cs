using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSingleResp
{
    public static class EntrerUser
    {
        public static User CapturerUtilisateur()
        {
            User output = new User();
            Console.WriteLine(Message.EntrerUtilisateur);
            output.NomUtilisateur = Console.ReadLine();

            Console.WriteLine(Message.EntrerMotPasse);
            output.MotPasse = Console.ReadLine();

            return output;
        }
    }
}
