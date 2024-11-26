using System;

namespace _003_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float minFloat = float.MinValue;
            float maxFloat = float.MaxValue;

            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;

            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;

            Console.WriteLine($"float \t Min : {minFloat} \t\t ~ Max : {maxFloat}");
            Console.WriteLine($"double \t Min : {minDouble} \t\t ~ Max : {maxDouble}");
            Console.WriteLine($"decimal \t Min : {minDecimal} \t\t ~ Max : {maxDecimal}");
        }
    }
}