using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumber
{
    class PlayerCharacter
    {
         public string Name { get; set; }
        public int DaySinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; //Magic Number
            DaySinceLastLogin = -1; //Magic Number
        }
    }
}
