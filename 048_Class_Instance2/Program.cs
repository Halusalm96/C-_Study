using System;

using Instance;

namespace _048_Class_Instance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //유닛 테스트
            {
                Barbarian[] barbarians = new Barbarian[10];

                barbarians[0] = new Barbarian();
                barbarians[1] = new Barbarian(10, 10);

                uint gainExp = barbarians[1].Damage(barbarians[0].GetAttack_Power());
                barbarians[0].Attack(gainExp);

                Console.WriteLine("\nResult\n");

                foreach (var item in barbarians)
                {
                    if (item != null)
                    {
                        item.PrintStat();
                    }
                }

                Console.WriteLine("");

                Giant[] giants = new Giant[10];
                giants[0] = new Giant();
                giants[1] = new Giant(10, 10);

                barbarians[0].Attack(giants[0].Damage(barbarians[0].GetAttack_Power()));
                barbarians[0].Attack(giants[0].Damage(barbarians[0].GetAttack_Power()));
                barbarians[0].Attack(giants[0].Damage(barbarians[0].GetAttack_Power()));

                Console.WriteLine("\nResult\n");

                foreach (var item in giants)
                {
                    if (item != null)
                    {
                        item.PrintStat();
                    }
                }

                foreach (var item in barbarians)
                {
                    if (item != null)
                    {
                        item.PrintStat();
                    }
                }

                Healer h1 = new Healer(10, 10);
                h1.Attack(giants[0].Damage(h1.GetAttack_Power()));
                h1.PrintStat();
                giants[0].PrintStat();
            }
        }
    }
}
