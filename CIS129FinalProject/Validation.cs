using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Validation
    {
        string input;
        string error = "Please enter the correct input";
        private bool valid;
        public void setInput(string input)
        {
            this.input = input;
        }
        public void validateInput()
        {

                if (input != "1" && input != "2" && input != "3" && input != "4")
                {
                    Console.WriteLine(error);
                    valid = false;
                }
                else
                {
                    valid = true;
                }
        }
        public bool getValid()
        {
            return valid;
        }
    }
}
