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

            DemageExp = Level * 4;

            if (isPrintStat) PrintStat();
        }

        public Giant(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }
    }
}
