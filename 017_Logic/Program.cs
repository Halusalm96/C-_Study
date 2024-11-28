using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //!
            {
                bool isCheck = false;

                isCheck = !isCheck;
                Console.WriteLine($"isCheck: {isCheck}");

                isCheck = !isCheck;
                Console.WriteLine($"isCheck: {isCheck}");
            }

            // &&, ||(OR)
            {
                Console.WriteLine("\n && ||");

                bool bTrue = true;
                bool bFalse = false;
                
                // &&(and) - T+T, T+F, F+T = true / F+F = false
                // ||(or) - T+T = true / T+F, F+T, F+F = false

                bool isResult = bTrue && bFalse;
                Console.WriteLine($"isResult: {isResult}");

                Console.WriteLine($"bTrue && bTrue: \t {bTrue && bTrue}");
                Console.WriteLine($"bTrue && bFalse:\t {bTrue && bFalse}");
                Console.WriteLine($"bFalse && bTrue:\t {bFalse && bTrue}");
                Console.WriteLine($"bFalse && bFalse:\t {bFalse && bFalse}");

                Console.WriteLine($"bTrue || bTrue: \t {bTrue || bTrue}");
                Console.WriteLine($"bTrue || bFalse:\t {bTrue || bFalse}");
                Console.WriteLine($"bFalse || bTrue:\t {bFalse || bTrue}");
                Console.WriteLine($"bFalse || bFalse:\t {bFalse || bFalse}");
            }

            //&, |, ^(XOR) - 함수의 값이 같으면 False, 다르면 True
            {
                Console.WriteLine("\n &, |, ^(XOR)");

                bool bTrue = true;
                bool bFalse = false;

                Console.WriteLine($"bTrue ^ bTrue:  \t{bTrue ^ bTrue}");
                Console.WriteLine($"bTrue ^ bFalse: \t{bTrue ^ bFalse}");
                Console.WriteLine($"bFalse ^ bTrue: \t{bFalse ^ bTrue}");
                Console.WriteLine($"bFalse ^ bFalse: \t{bFalse ^ bFalse}");
            }

            //? (Nullable)
            {
                Console.WriteLine("\n Nullable");

                //bool is = null;
                bool? test = null;
                Console.WriteLine($"!test: {!test}"); //null
                Console.WriteLine($"test ^ null: null"); //null

                test = false;
                Console.WriteLine($"!test: {!test}"); //true
            }

            //복합 할당(우선 순위: !, &, |, &&, ||)
            {
                Console.WriteLine("\n 복합 할당(우선 순위: !, &, |, &&, ||)");

                bool bTrue = true;
                bool bFalse = false;

                Console.WriteLine($"bTrue | bTrue & bFalse: {bTrue | bTrue & bFalse}");
                Console.WriteLine($"(bTrue | bTrue) & bFalse: {(bTrue | bTrue) & bFalse}");
                Console.WriteLine($"!bTrue | !bTrue & !bFalse: {!bTrue | !bTrue & !bFalse}");
            }
        }
    }
}
