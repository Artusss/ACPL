using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src.Core.Translator
{
    class Parser
    {
        private Dictionary<int, string> Operations;

        const string VAR      = "var";
        const string INT      = "int";
        const string DOUBLE   = "double";
        const string STRING   = "string";
        const string LIST     = "list";
        const string HAVE     = "have";
        const string PLUS     = "plus";
        const string MINUS    = "minus";
        const string MULTIPLY = "multiply";
        const string SPLIT    = "split";
        const string PRINT    = "print";

        const string ARITHMETIC_MASK = "";
        const string PRINT_MASK      = "";

        public Parser(Inputer inputer)
        {
            Operations = new Dictionary<int, string>();
            Queue<string> Lines = inputer.InvokeToParser();
            while (Lines.Count > 0)
            {
                string Line = Lines.Dequeue().Trim();
                if (Line.Equals(""))
                {
                    if (this.IsInitVarOperation(Line))
                    {
                        Operations.Add(2, Line);
                    }
                    else if (this.IsInitIntOperation(Line))
                    {
                        Operations.Add(2, Line);
                    }
                    else if (this.IsInitDoubleOperation(Line))
                    {
                        Operations.Add(2, Line);
                    }
                    else if (this.IsInitStringOperation(Line))
                    {
                        Operations.Add(2, Line);
                    }
                    else if (this.IsInitListOperation(Line))
                    {
                        Operations.Add(2, Line);
                    }
                    else if (this.IsPlusOperation(Line))
                    {
                        Operations.Add(1, Line);
                    }
                    else if (this.IsMinusOperation(Line))
                    {
                        Operations.Add(1, Line);
                    }
                    else if (this.IsMultiplyOperation(Line))
                    {
                        Operations.Add(1, Line);
                    }
                    else if (this.IsSplitOperation(Line))
                    {
                        Operations.Add(1, Line);
                    }
                    else if (this.IsPrintOperation(Line))
                    {
                        Operations.Add(3, Line);
                    }
                }
            }
        }
        
        public Dictionary<int, string> InvokeToLexer()
        {
            return this.Operations;
        }

        private bool IsInitVarOperation(string Line)
        {
            string INIT_VAR_MASK = $"^{VAR}\\s\\w+\\s{HAVE}\\s\\w+";
            return  Regex.IsMatch(Line, INIT_VAR_MASK);
        }

        private bool IsInitIntOperation(string Line)
        {
            string INIT_INT_MASK = $"^{INT}\\s\\w+\\s{HAVE}\\s\\w+";
            return Regex.IsMatch(Line, INIT_INT_MASK);
        }

        private bool IsInitDoubleOperation(string Line)
        {
            string INIT_DOUBLE_MASK = $"^{DOUBLE}\\s\\w+\\s{HAVE}\\s\\w+";
            return Regex.IsMatch(Line, INIT_DOUBLE_MASK);
        }

        private bool IsInitStringOperation(string Line)
        {
            string INIT_STRING_MASK = $"^{STRING}\\s\\w+\\s{HAVE}\\s\\w+";
            return Regex.IsMatch(Line, INIT_STRING_MASK);
        }

        private bool IsInitListOperation(string Line)
        {
            string INIT_LIST_MASK = $"^{LIST}\\s\\w+\\s{HAVE}\\s\\w+";
            return Regex.IsMatch(Line, INIT_LIST_MASK);
        }

        private bool IsPlusOperation(string Line)
        {
            string PLUS_MASK = $"^\\w+\\s{HAVE}\\s\\w+\\s{PLUS}\\s\\w+";
            return Regex.IsMatch(Line, PLUS_MASK);
        }

        private bool IsMinusOperation(string Line)
        {
            string MINUS_MASK = $"^\\w+\\s{HAVE}\\s\\w+\\s{MINUS}\\s\\w+";
            return Regex.IsMatch(Line, MINUS_MASK);
        }

        private bool IsMultiplyOperation(string Line)
        {
            string MULTIPLY_MASK = $"^\\w+\\s{HAVE}\\s\\w+\\s{MULTIPLY}\\s\\w+";
            return Regex.IsMatch(Line, MULTIPLY_MASK);
        }

        private bool IsSplitOperation(string Line)
        {
            string SPLIT_MASK = $"^\\w+\\s{HAVE}\\s\\w+\\s{SPLIT}\\s\\w+";
            return Regex.IsMatch(Line, SPLIT_MASK);
        }
        private bool IsPrintOperation(string Line)
        {
            string PRINT_MASK = $"^{PRINT}\\s\\w+";
            return Regex.IsMatch(Line, PRINT_MASK);
        }
    }
}
