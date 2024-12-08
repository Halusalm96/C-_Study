using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Instance
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
            }
        }
    }
}
