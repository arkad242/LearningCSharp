using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp_Block5
{
    public class Character
    {
        public int Health { get; private set; } = 100;

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            //health -= damage;
            Health -= damage;
        }

    }
}
