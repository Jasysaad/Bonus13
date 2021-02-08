using System;
using System.Collections.Generic;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters= new GameCharacter[5];

            Console.Write("Enter player name: ");
            var name = Console.ReadLine();
            Console.Write("Enter strength from 1-10: ");
            var strength = int.TryParse(Console.ReadLine(), out var resultstrength) ? resultstrength : default;
            Console.Write("Enter intelligence from 1-10: ");
            var intel = int.TryParse(Console.ReadLine(), out var resultintel) ? resultintel : default;


            gameCharacters[0] = new Wizard(intel, strength, name, 7, 7);
            gameCharacters[1] = new Wizard(intel, strength, name, 8, 2);
            gameCharacters[2] = new Wizard(intel, strength, name, 3, 7);
            gameCharacters[3] = new Warrior(intel, strength, name, "bow and arrow");
            gameCharacters[4] = new Warrior(intel, strength, name, "true love");

         
            
            foreach (var character in gameCharacters)
            {
                Console.WriteLine(character.Play());
            }
        }
    }
}
