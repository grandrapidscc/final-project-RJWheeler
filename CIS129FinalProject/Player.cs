using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    class Player
    {
        private string playerName = "Wizert";
        private int maxHP = 100;
        public int currentHP = 100;
        private int maxMP = 200;
        public int currentMP = 200;
        private string attackName = "Fireball";
        private int damage = 5;
        private string heal = "Heal";
        private int healHP = 3;
        public void currentHPMP()
        {
            Console.WriteLine($"Your current HP is {currentHP} / {maxHP} and your current MP is {currentMP} / {maxMP}");
        }
        public void takeDamage(int damageTaken)
        {
            currentHP = currentHP - damageTaken;
            if (currentHP <= 0)
            {
                Console.WriteLine($"{playerName} has been slain.");
            }
            else
            {
                Console.WriteLine($"{playerName} has taken {damageTaken} damage and has {currentHP} HP left.");
            }
        }
        public int damageDealt()
        {
            Console.WriteLine($"{playerName} is  casting {attackName}.");
            if (currentMP >= 3)
            {
                currentMP = currentMP - 3;
                return damage;
            }
            else
            {
               Console.WriteLine($"Not enough MP to cast {attackName}.");
                return 0;
            }
            
        }
        public void healing()
        {
            Console.WriteLine($"{playerName} is  casting {heal}.");
            if (currentMP >= 5)
                {
                 currentMP = currentMP - 5;
                 currentHP = currentHP + 3;
                 Console.WriteLine($"{playerName} is Healing. Current HP is {currentHP} / {maxHP} and current MP left is {currentMP}");
                }
            else
            {
                Console.WriteLine($"Not enough MP to cast {heal}.");
            }
        }
        public void getHealthPotion()
        {
            Console.WriteLine($"{playerName} has found  a health potion!!");
            if (currentHP < 91) {
                currentHP = currentHP + 10;
                
            }
            else 
            {
                currentHP = maxHP;
            }
            Console.WriteLine($"{playerName} is Healing. Current HP is {currentHP} / {maxHP}.");
        }
        public void getManaPotion()
        {
            Console.WriteLine($"{playerName} has found  a mana potion!!");
            if (currentMP < 181)
            {
                currentMP = currentMP + 20;
            }
            else
            {
                currentMP = maxMP;
            }
            Console.WriteLine($"{playerName} is resoring mana. Current MP is {currentMP} / {maxMP}.");
        }
        public int getHp()
        {
            return currentHP;
        }
    }
}
