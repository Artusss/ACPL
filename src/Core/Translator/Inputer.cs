using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using src.Core.Exceptions;

namespace src.Core.Translator
{
    class Inputer
    {
        const string FILE_EXTENSION = ".acpl";

        private Queue<string> Lines;

        public Inputer(string FilePath)
        {
            if (!FilePath.EndsWith(FILE_EXTENSION)) throw new CompilerException("File extension is incorrect");

            Lines = new Queue<string>();

            using (StreamReader sr = new StreamReader(FilePath, System.Text.Encoding.Default))
            {
                string Line;
                while ((Line = sr.ReadLine()) != null)
                {
                    Lines.Enqueue(Line);
                }
            }
        }

        public Queue<string> InvokeToParser()
        {
            return Lines;
        }
    }
}
