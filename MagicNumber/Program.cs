using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Priyanka";

            PlayerDisplayer.write(player);
        }
    }
}
