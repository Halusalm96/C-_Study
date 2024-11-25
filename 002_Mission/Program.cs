using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte minSbyte = sbyte.MinValue;
            sbyte maxSbyte = sbyte.MaxValue;

            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            short minShort = short.MinValue;
            short maxShort = short.MaxValue;

            ushort minUShort = ushort.MinValue;
            ushort maxUShort = ushort.MaxValue;

            int minInt = int.MinValue;
            int maxInt = int.MaxValue;

            long minLong = long.MinValue;
            long maxLong = long.MaxValue;

            ulong minULong = ulong.MinValue;
            ulong maxULong = ulong.MaxValue;

            Console.WriteLine($"sbyte \t Min : {minSbyte} \t ~ Max : {maxSbyte}");
            Console.WriteLine($"byte \t Min : {minByte} \t ~ Max : {maxByte}");
            Console.WriteLine($"short \t Min : {minShort} \t ~ Max : {maxShort}");
            Console.WriteLine($"ushort \t Min : {minUShort}  \t ~ Max : {maxUShort}");
            Console.WriteLine($"int \t Min : {minInt} \t ~ Max : {maxInt}");
            Console.WriteLine($"long \t Min : {minLong} \t ~ Max : {maxLong}");
            Console.WriteLine($"ulong \t Min : {minULong} \t ~ Max : {maxULong}");

        }
    }
}
