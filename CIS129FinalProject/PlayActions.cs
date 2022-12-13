using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class PlayActions
    {
        int x;
        int y;
        private int startingx;
        private int startingy;
        private int endx;
        private int endy;
        bool atend;
        bool battle;
        bool finditem;
        Random rnd = new Random();
        public void startingPoint()
        {
            startingx = rnd.Next(0,4);
            startingy = rnd.Next(0,4);
            endx = rnd.Next(0,4);
            endy = rnd.Next(0,4);
            x = startingx;
            y = startingy;
            atend = false;
            battle = false;
            finditem = false;
        }
        public void moving(string input)
        {
            if (input == "1")
            {
                x = x +1;
            }
            else if(input == "2")
            {
                x = x -1;
            }
            else if(input == "3")
            {
                y = y +1;
            }
            else if (input == "4")
            {
                y = y - 1;
            }
            if (x < 5 && x >= 0 && y < 5 && y >= 0)
            {
                isAtEnd();
                isBattle();
                isFindItem();
            }
            else
            {
                Console.WriteLine("You have hit a wall please choose a differnet direction");
                if (input == "1")
                {
                    x = x - 1;
                }
                else if (input == "2")
                {
                    x = x + 1;
                }
                else if (input == "3")
                {
                    y = y - 1;
                }
                else if (input == "4")
                {
                    y = y + 1;
                }
            }
        }
        private void isAtEnd()
        {
            if (x == endx && y == endy)
            {
                atend = true;
            }
        }
        private void isBattle()
        {
            int location = x + y;
            if (location % 2 == 0)
            {
                battle = true;
            }
        }

        private void isFindItem()
        {
            int location = x + y;
            if (location % 2 != 0)
            {
                finditem = true;
            }
        }
        public bool GetAtEnd()
        {
            return atend;
        }
        public bool GetBattle()
        {
            return battle;
        }
        public bool GetIsFindItem()
        {
            return finditem;
        }
    }
}
