using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Healer : Army
    {
        public Healer(bool isPrintStat = true) : base()
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 50;

            Name = "힐 러";

            DemageExp = Level * 3;

            if (isPrintStat) PrintStat();
        }

        public Healer(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }
    }
}
