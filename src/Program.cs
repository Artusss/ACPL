using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace src
{
    public enum ResWords
    {
        INT = 'i',
        DOUBLE = 'd',
        STRING = 's',
        LIST = 'l',
        HAVE = '=',
        PLUS = '+',
        MINUS = '-',
        MULT = '*',
        SPLIT = '/',
        LP = '(',
        RP = ')',
        PRINT = ':'
    }

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex;
            string plus_pattern = $"";
            Console.WriteLine(ResWords.PLUS);
            string rawExp = "5 + 6 * ( 9 - 4 )";


            Console.WriteLine("Hello World!");
        }


    }
}
