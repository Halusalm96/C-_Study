using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instance;

namespace _050_Class_Instance3
{
    class Program
    {
        const uint MAX_ARRAY = 20;

        static void Main(string[] args)
        {
            Army[] armies = new Army[MAX_ARRAY];
            int currentIndex = 0;

            int selectNum = 0;

            while(true)
            {
                Console.WriteLine("===================================================");
                Console.Write("메뉴 선택[1]유닛 생성 [2]유닛 공격 [9]정보보기(0번 나가기)");
                selectNum = int.Parse(Console.ReadLine());

                if (selectNum <= 0)
                {
                    Console.WriteLine("나가기 완료.");
                    break;
                }

                switch (selectNum)
                {
                    case 1:
                        CreateArmy(armies, ref currentIndex);
                        break;

                    case 2:
                        AttackArmy(armies);
                        break;

                    case 9:
                        PrintStat(armies, currentIndex);
                        break;

                    default:
                        Console.WriteLine("메뉴가 없습니다.");
                        break;
                }
            }
        }

        static void CreateArmy(Army[] armies, ref int currentIndex)
        {
            while(true)
            {
                int selectMenu = 0;
                Console.Write("유닛 선택  [1]거인 [2]바바리안 [3]힐러 [9]정보보기(0번 메인 메뉴)");
                selectMenu = int.Parse(Console.ReadLine());

                if(selectMenu == 0)
                {
                    break;
                }

                if(currentIndex >= MAX_ARRAY)
                {
                    Console.WriteLine("최대 유닛 생성 완료 더 이상 생성 불가!!");
                    continue;
                }

                switch (selectMenu)
                {
                    case 1:
                        armies[currentIndex++] = new Giant();
                        break;
                    case 2:
                        armies[currentIndex++] = new Barbarian();
                        break;
                    case 3:
                        armies[currentIndex++] = new Healer();
                        break;

                    case 9:
                        PrintStat(armies, currentIndex);
                        break;

                    default:
                        Console.WriteLine("정확한 번호를 선택하세요");
                        break;
                }
            }
        }

        static void PrintStat(Army[] armies, int currentIndex)
        {
            Console.WriteLine("생성된 유닛 수: " + currentIndex);

            for (int i = 0; i < armies.Length; i++)
            {
                if (armies[i] != null)
                {
                    Console.Write($"유닛 번호: {i},  ");
                    armies[i].PrintStat();
                }
            }
        }

        static void AttackArmy(Army[] armies)
        {

        }
    }
}
