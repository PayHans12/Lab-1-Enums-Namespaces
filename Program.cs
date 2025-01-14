using System.Diagnostics;
using GameEnums;

int choice;
GameDifficulty difficulty;
CharacterClass playerClass;
Console.Clear();

Console.Write("Select a Difficulty \n1.Easy \n2.Medium \n3.Hard ");

difficulty = (GameDifficulty)ReturnInteger(Console.ReadLine()); //casts the integer into the Enum

Console.Write("\nSelect a Character Class \n1.Warrior \n2.Mage \n3.Rogue ");

playerClass = (CharacterClass)ReturnInteger(Console.ReadLine()); //casts the integer into the Enum

//Displays the users choices
Console.WriteLine($"\nYou selected: \nDifficulty: {difficulty} \nCharacter Class: {playerClass}");

int ReturnInteger(string input)
{
    while (true)
    {
        //Checks the value that the user enters and ensures that they can only
        //enter the values that you are looking for
        //It contunues until they either exit the program or enter the correct values
        try
        {
            choice = int.Parse(input);
            if (choice >= 1 && choice <= 3)
            {
                return choice;
            }
            else
            {
                Console.Write("Please enter a value between 1-3: ");
            }
        }
        catch
        {
            Console.Write("Please enter a valid Integer: ");
        }
    }
}