﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Barbarian : AbstractArmy
    {
/*        public Barbarian(bool isPrintStat = true) : base()
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 10;

            Name = "바바리안";

            DamageExp = Level * 2;

            if (isPrintStat) PrintStat();
        }*/

/*        public Barbarian(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }*/

        public override void Move(int x, int y)
        {
            base.SetMove(x, y);
            Console.WriteLine($"바바리언 이동 => 위치 X: {PositionX}  위치 Y: {PositionY}");
        }

        public override void Attack(AbstractArmy damageArmy)
        { 
            base.SetAttack(damageArmy);

            string damageName = damageArmy.GetName();
            uint gainExp = damageArmy.GetDamageExp();

            Console.WriteLine($"{Name}이 {damageName}을 주먹 공격!!");
            Console.WriteLine($"{Name}이 {gainExp} 획득!!");
        }

        public override void InitData()
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 10;

            Name = "바바리안";

            DamageExp = Level * 2;

            PrintStat();
        }
    }
}
