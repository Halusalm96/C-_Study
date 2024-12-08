using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Healer : AbstractArmy
    {
   /*     public Healer(bool isPrintStat = true)
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 50;

            Name = "힐 러";

            DamageExp = Level * 3;

            if (isPrintStat) PrintStat();
        }

        public Healer(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }*/

        public override void Attack(AbstractArmy damageArmy)
        {
            base.SetAttack(damageArmy);
            string damageName = damageArmy.GetName();
            uint gainExp = damageArmy.GetDamageExp();

            Console.WriteLine($"{Name}이 {damageName}을 마법으로 공격!!");
            Console.WriteLine($"{Name}이 {gainExp} 획득!!");

        }

        public override void InitData()
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 50;

            Name = "힐 러";

            DamageExp = Level * 3;

            PrintStat();
        }

        public override void Move(int x, int y)
        {
            base.SetMove(x, y);
            Console.WriteLine($"힐러 이동 => 위치 X: {PositionX}  위치 Y: {PositionY}");
        }
    }
}
