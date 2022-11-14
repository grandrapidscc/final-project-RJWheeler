using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
     class Enemies
    {
        private string enemyName;
        private int maxHp;
        public int currentHP;
        private string attackName;
        private int damage;
        public  Enemies(string enemyName, int maxHP, string attackName, int damage)
        {
            this.enemyName = enemyName;
            this.maxHp = maxHP;
            currentHP = maxHP;
            this.attackName = attackName;
            this.damage = damage;
        }
        public string getName()
        {
            return enemyName;
        }
        public int getMaxHP()
        {
            return maxHp;
        }
        public int getCurrentHP()
        {
            return currentHP;
        }
        public string getAttackName()
        {
            return attackName;
        }
        public int getDamage()
        {
            return damage;
        }
        public void takeDamage(int damageTaken)
        {
            currentHP = currentHP - damageTaken;
            if (currentHP <= 0)
            {
                Console.WriteLine($"{enemyName} has been slain.");
                currentHP = maxHp;
            }
            else
            {
                Console.WriteLine($"{enemyName} has taken {damageTaken} damage and has {currentHP} HP left.");
            }
        }
        public int damageDealt()
        {
            Console.WriteLine($"{enemyName} is  attacks with  {attackName}.");
            return damage;
        }
    }
}
