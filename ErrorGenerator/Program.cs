using System;
using ErrorGenerator.DummyError;

namespace ErrorGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string output = "";
                if (int.TryParse(args[0], out int NumErrors))
                {
                    for (int index = 0; index < NumErrors; index++)
                    {
                        output += $"{ErrorStrings.FullError()}\n";
                    }
                    Console.Write(output);
                }
            }
            Console.WriteLine(ErrorStrings.FullError());
        }
    }
}
