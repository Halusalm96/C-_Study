using System;

namespace _008_Enum
{
    enum COLOR_TYPR
    {
        WHITE, //0
        RED,   //1
        BLUE,  //2
        SIZE,  //3
    }

    enum DAY : ushort
    {
        SUNDAY,
        MONDAY,
        THEDAY,
        WEDDAY,
        FRIDAY,
        SATURDAY,
        WEEKDAY,
    }

    enum NUMBER
    {
        ONE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE = 5,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"COLOR_TYPR.WHITE : {COLOR_TYPR.WHITE}");
            Console.WriteLine($"COLOR_TYPR.BLUE : {COLOR_TYPR.BLUE}");

            Console.WriteLine($"COLOR_TYPR.WHITE : {(int)COLOR_TYPR.WHITE}");
            Console.WriteLine($"COLOR_TYPR.BLUE : {(int)COLOR_TYPR.BLUE}");

            // 변환
            {
                DAY day = DAY.SUNDAY;

                Console.WriteLine($"day : {(short)day}");
                Console.WriteLine($"DAY.SUNDAY : {(short)DAY.SUNDAY}");

                int total = (short)DAY.SUNDAY + (short)DAY.WEEKDAY;
                Console.WriteLine($"total : {total}");
            }

            {
                Console.WriteLine($"NUMBER.ONE : {(int)NUMBER.ONE}");
                Console.WriteLine($"NUMBER.TWO : {(int)NUMBER.TWO}");
                Console.WriteLine($"NUMBER.THREE : {(int)NUMBER.THREE}");
                Console.WriteLine($"NUMBER.FOUR : {(int)NUMBER.FOUR}");
                Console.WriteLine($"NUMBER.FIVE : {(int)NUMBER.FIVE}");
            }
        }
    }
}
