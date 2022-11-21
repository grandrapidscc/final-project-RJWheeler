using CIS129FinalProject;
Player wiz = new Player();
Enemies goblin = new Enemies("Goblin", 3, "Body Slam", 2);
Enemies orc = new Enemies("Orc", 5, "CLeave", 3);
Enemies banshee = new Enemies("Banshee", 8, "Screech", 5);
Console.WriteLine("Welcome to Wizert. You are a powerful wizard trapped in a dungeon. Find the exit before the monsters find you and defeat you. All input you give are in the form of number from 1 to 4. Good luck!!");
//put map starting here and make input grab a loop.
string input = Console.ReadLine();
Validation valid = new Validation();
valid.setInput(input);
valid.validateInput();
if (valid.getValid())
{
    Console.WriteLine("this is valid.");
}
