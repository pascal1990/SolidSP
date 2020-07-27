using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSingleResp
{
    public static class ValidateUser
    {
        public static bool isValiteUser(User user)
        {
            bool isValite = true;

            if (string.IsNullOrWhiteSpace(user.NomUtilisateur))
            {
                Console.WriteLine(Message.ErrorNomUtilisateur);
                isValite = false;
            }
            if (string.IsNullOrWhiteSpace(user.MotPasse))
            {
                Console.WriteLine(Message.ErrorMotPasse);
                isValite = false;
            }

            return isValite;
        }
    }
}
