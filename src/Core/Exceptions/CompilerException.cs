using System;
using System.Collections.Generic;
using System.Text;

namespace src.Core.Exceptions
{
    class CompilerException : Exception
    {
        public CompilerException() : base()
        {

        }
        public CompilerException(string Message) : base(Message)
        {

        }
        public CompilerException(string Message, Exception Inner) : base(Message, Inner)
        {

        }
    }
}
