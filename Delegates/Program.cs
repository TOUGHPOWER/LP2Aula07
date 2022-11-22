using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {


        static void Main(string[] args)
        {
            StringDelegate myDel;
            Console.WriteLine("Hello, World!");
            Joiner joiner = new Joiner("Primeira");
            myDel = PrintUpper;
            myDel+= PrintLower;
            myDel += joiner.JoinAndPrint;
            myDel.Invoke("Segundo");

        }

        static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
