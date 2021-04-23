using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumber
{
    class PlayerDisplayer
    {
        public static void write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaySinceLastLogin == -1)
            {
                Console.WriteLine("No value for daySinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaySinceLastLogin);
            }

            if (player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
