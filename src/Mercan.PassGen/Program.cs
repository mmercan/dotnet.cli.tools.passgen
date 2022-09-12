using System;
using CommandLine;

namespace Mercan.PassGen
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArgsOptions argsOptions = new ArgsOptions();
            Parser.Default.ParseArguments<ArgsOptions>(args).WithParsed<ArgsOptions>(o => { argsOptions = o; });

            if (argsOptions.MinLength > argsOptions.MaxLength)
            {
                var temp = argsOptions.MaxLength;
                argsOptions.MaxLength = argsOptions.MinLength;
                argsOptions.MinLength = temp;
            }

            var password = PasswordGenerator.Generate(argsOptions);

            // Console.WriteLine("minimum Length  : " + argsOptions.MinLength.ToString() +
            //                   " maximum Length : " + argsOptions.MaxLength.ToString() +
            //                   " ExcludeSymbols : " + argsOptions.ExcludeSymbols.ToString() +
            //                   " ExcludeChars   : " + argsOptions.Excludes +
            //                   " password       : " + password);

        
            Console.WriteLine(password);
           
        }


        private static int extractIntFromReadLine(string message, int minLength = 0)
        {
            bool valid = false;
            int result = -1;
            do
            {
                Console.WriteLine(message);
                valid = Int32.TryParse(Console.ReadLine(), out result);
            }
            while (!(result > minLength));
            return result;
        }

        private static bool extractBoolFromReadLine(string message)
        {
            bool valid = false;
            bool result = false;
            do
            {
                Console.WriteLine(message);
                valid = bool.TryParse(Console.ReadLine(), out result);
            }
            while (!valid);
            return result;
        }
    }

}