using GameEnums;

int choice;
GameDifficulty difficulty;
CharacterClass playerClass;
Console.Clear();

Console.Write("Select a Difficulty \n1.Easy \n2.Medium \n3.Hard ");

while (true)
{
    //Checks the value that the user enters and ensures that they can only
    //enter the values that you are looking for
    //It contunues until they either exit the program or enter the correct values
    try
    {
        choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 3)
        {
            difficulty = (GameDifficulty)choice;
            break;
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

Console.Write("\nSelect a Character Class \n1.Warrior \n2.Mage \n3.Rogue ");

while (true)
{
    //Checks the value that the user enters and ensures that they can only
    //enter the values that you are looking for
    //It contunues until they either exit the program or enter the correct values
    try
    {
        choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 3)
        {
            playerClass = (CharacterClass)choice;
            break;
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

//Displays the users choices
Console.WriteLine($"\nYou selected: \nDifficulty: {difficulty} \nCharacter Class: {playerClass}");