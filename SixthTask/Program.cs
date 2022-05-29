using System;

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] prostranstvo = { ' ', '\n', '\t' };
            string s = " this is a \nzhopa";
            Console.WriteLine("До" + s);
            Console.Write("После ");
            for (; ; )
            {
                int offset = s.IndexOfAny(prostranstvo);
                if (offset == -1)
                {
                    break;
                }
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);

                s = string.Concat(before, after);
            }
            Console.WriteLine(s);

            Console.WriteLine("Haжмитe <Enter> для завершения программы ... ");

            Console.Read();
        }

    }
}


