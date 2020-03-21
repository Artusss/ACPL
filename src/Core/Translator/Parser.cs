using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src.Core.Translator
{
    public enum ResWords
    {
        INT      = 'i',
        DOUBLE   = 'd',
        STRING   = 's',
        LIST     = 'l',
        HAVE     = '=',
        PLUS     = '+',
        MINUS    = '-',
        MULT     = '*',
        SPLIT    = '/',
        LP       = '(',
        RP       = ')',
        PRINT    = ':'
    }

    class Parser
    {
        private Dictionary<string, string> Variables;
        private Dictionary<int, string> Operations;

        public Parser(Inputer inputer)
        {
            Operations = new Dictionary<int, string>();
            Queue<string> Lines = inputer.InvokeToParser();
            while (Lines.Count > 0)
            {
                string Line = Lines.Dequeue().Trim();
                if (!Line.Equals(""))
                {
                    
                }
            }
        }
        
        public Dictionary<int, string> InvokeOperationsToLexer()
        {
            return this.Operations;
        }

        public Dictionary<string, string> InvokeVariablesToLexer()
        {
            return this.Variables;
        }
    }
}
