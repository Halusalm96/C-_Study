using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Giant : Army
    {
        public Giant(bool isPrintStat = true) : base()
        {
            Hp = 1000;

            Movement_Speed = 1;
            Attack_Power = 100;

            Name = "거 인";

            DamageExp = Level * 4;

            if (isPrintStat) PrintStat();
        }

        public Giant(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
            Console.WriteLine($"거 인 이동 => 위치 X: {PositionX}  위치 Y: {PositionY}");
        }

        public override void Attack(Army damageArmy)
        {
            base.Attack(damageArmy);

            string damageName = damageArmy.GetName();
            uint gainExp = damageArmy.GetDamageExp();

            Console.WriteLine($"{Name}이 {damageName}을 몸으로 돌격 공격!!");
            Console.WriteLine($"{Name}이 {gainExp} 획득!!");
        }
    }
}
