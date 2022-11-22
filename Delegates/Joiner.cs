using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    public class Joiner
    {
        private string firstString;

        public Joiner(string theFirstString)
        {
            firstString = theFirstString;
        }

        public void JoinAndPrint(string secondString)
        {
            Console.WriteLine(firstString + secondString);
        }
    }
}