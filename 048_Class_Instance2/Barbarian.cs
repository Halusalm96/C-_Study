using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Barbarian : Army
    {
        public Barbarian(bool isPrintStat = true) : base()
        {
            Hp = 500;

            Movement_Speed = 10;
            Attack_Power = 10;

            Name = "바바리안";

            DemageExp = Level * 2;

            if (isPrintStat) PrintStat();
        }

        public Barbarian(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }
    }
}
