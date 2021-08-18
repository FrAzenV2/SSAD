using System;

namespace SSAD_Lab1.Example
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some Directory path!");
            bool isPathValid;
            int filesAmount;
            do
            {
                var path = @""+Console.ReadLine();
                isPathValid = SubfoldersAmountGetter.TryGetFilesAmount(path, out var amount);
                filesAmount = amount;
            } while (!isPathValid);
            Console.Write(filesAmount + " - files in this folder");
        }
    }
}