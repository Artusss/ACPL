using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace src.Core.Translator
{
    class Lexer
    {
        private Dictionary<string, string> Variables;

        public Lexer()
        {

        }

        private void setVar(List<string> curLexem_imp)
        {
            var varKey = curLexem_imp.First();
            if (Variables.ContainsKey(varKey))
            {

                return;
            }
        }
    }
}
