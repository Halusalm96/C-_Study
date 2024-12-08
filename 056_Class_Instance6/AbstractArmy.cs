using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    abstract class AbstractArmy : Army, IArmy
    {
        public AbstractArmy() : base()
        {
            InitData();
        }

        protected void SetMove(int x, int y)
        {
            base.Move(x, y);
        }

        protected void SetAttack(AbstractArmy damageArmy)
        {
            damageArmy.Damage(this.Attack_Power);
            this.Attack(damageArmy.GetDamageExp());
        }

        public abstract void InitData();
        public abstract override void Move(int x, int y);
        public abstract void Attack(AbstractArmy damageArmy);
        public abstract void Patrol();
    }
}
