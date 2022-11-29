using CIS129FinalProject;
Player wiz = new Player();
Enemies goblin = new Enemies("Goblin", 3, "Body Slam", 2);
Enemies orc = new Enemies("Orc", 5, "CLeave", 3);
Enemies banshee = new Enemies("Banshee", 8, "Screech", 5);
Console.WriteLine("Welcome to Wizert. You are a powerful wizard trapped in a dungeon. Find the exit before the monsters find you and defeat you. All input you give are in the form of number from 1 to 4. Good luck!!");
PlayActions map = new PlayActions();
Validation valid = new Validation();
Random rnd = new Random();
while (!map.GetAtEnd() && wiz.getHp() > 0) {
    Console.WriteLine("You are in a room illuminated by torches.  It reeks of rotting waste, though you do not see any nearby.  Press...\r\n1.\tTo go north\r\n2.\tTo go south\r\n3.\tTo go east\r\n4.\tTo go west");
    string input = Console.ReadLine();
    valid.setInput(input);
    valid.validateInput();
    if (valid.getValid())
    {
        map.moving(input);
        if (map.GetAtEnd())
        {
            break;
        }
        else if (map.GetBattle())
        {
            int enemy = rnd.Next(1, 100);
            string battleInput;
            if (enemy % 3 == 0)
            {
                Console.WriteLine($"A goblin blocks your path.");
                while (goblin.getCurrentHP() > 0 && wiz.getHp() > 0)
                {
                    Console.WriteLine($"You have encountered a {goblin.getName()}.\r\nIt's the current HP {goblin.getCurrentHP()}.\r\nPress...\r\n1.\tTo Attack\r\n2.\tTo Heal\r\n3.\tTo Attempt to Flee");
                    battleInput = Console.ReadLine();
                    valid.setInput(battleInput);
                    valid.validateInput();
                    if (valid.getValid())
                    {
                        if(battleInput == "1")
                        {
                            wiz.takeDamage(goblin.damageDealt());
                            goblin.takeDamage(wiz.damageDealt());
                        }
                        else if (battleInput == "2")
                        {
                            wiz.healing();
                            wiz.takeDamage(goblin.damageDealt());
                        }
                        else if(battleInput == "3")
                        {
                            int fleeing = rnd.Next();
                            if (fleeing % 3 == 0)
                            {
                                Console.WriteLine("You have Successfully escaped.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have failed at fleeing.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please pick from the 3 choices");
                        }
                    }


                }
                goblin.setHP();

            }
            else if (enemy % 2 == 0)
            {
                Console.WriteLine($"You come into a room and It reeks of orc. You see it sitting in the corner Holding an axe. It's current HP is {orc.getCurrentHP()}");
                while (orc.getCurrentHP() > 0 && wiz.getHp() > 0)
                {
                    Console.WriteLine($"You have encountered a {orc.getName()}.\r\nIt's the current HP {orc.getCurrentHP()}.\r\nPress...\r\n1.\tTo Attack\r\n2.\tTo Heal\r\n3.\tTo Attempt to Flee");
                    battleInput = Console.ReadLine();
                    valid.setInput(battleInput);
                    valid.validateInput();
                    if (valid.getValid())
                    {
                        if (battleInput == "1")
                        {
                            wiz.takeDamage(orc.damageDealt());
                            orc.takeDamage(wiz.damageDealt());
                        }
                        else if (battleInput == "2")
                        {
                            wiz.healing();
                            wiz.takeDamage(orc.damageDealt());
                        }
                        else if (battleInput == "3")
                        {
                            int fleeing = rnd.Next();
                            if (fleeing % 3 == 0)
                            {
                                Console.WriteLine("You have Successfully escaped.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have failed at fleeing.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please pick from the 3 choices");
                        }
                    }


                }
                orc.setHP();
            }
            else if (enemy % 1 == 0)
            {
                Console.WriteLine($"You hear a piercing scream.You see the ghostly form of a banshee. It's current HP is {banshee.getCurrentHP()}");
                while (banshee.getCurrentHP() > 0 && wiz.getHp() > 0)
                {
                    Console.WriteLine($"You have encountered a {banshee.getName()}.\r\nIt's the current HP {banshee.getCurrentHP()}.\r\nPress...\r\n1.\tTo Attack\r\n2.\tTo Heal\r\n3.\tTo Attempt to Flee");
                    battleInput = Console.ReadLine();
                    valid.setInput(battleInput);
                    valid.validateInput();
                    if (valid.getValid())
                    {
                        if (battleInput == "1")
                        {
                            wiz.takeDamage(banshee.damageDealt());
                            banshee.takeDamage(wiz.damageDealt());
                        }
                        else if (battleInput == "2")
                        {
                            wiz.healing();
                            wiz.takeDamage(banshee.damageDealt());
                        }
                        else if (battleInput == "3")
                        {
                            int fleeing = rnd.Next();
                            if (fleeing % 3 == 0)
                            {
                                Console.WriteLine("You have Successfully escaped.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have failed at fleeing.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please pick from the 3 choices");
                        }
                    }


                }
                banshee.setHP();
            }
        }
        else if (map.GetIsFindItem())
        {
            int itemnum = rnd.Next();
            if(itemnum % 2 == 0)
            {
                wiz.getHealthPotion();
            }
            else
            {
                wiz.getManaPotion();
            }
        }
    }
}
if (map.GetAtEnd() && wiz.getHp() > 0)
{
    Console.WriteLine("Congratulations!!! You have made it out of the Dungeon safely");
}
