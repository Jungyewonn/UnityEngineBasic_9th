﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHeritance
{
    // 추상멤버를 가지고있다.
    // -> 해당 멤버를 가지는 클래스가 인스턴스화 가능하다면 해당 함수를 호출할수 있어야하는데 모순이 생긴다.
    // -> 추상 멤버를 가지고있으면, 클래스 마찬가지로 추상 클래스여야한다.
    internal abstract class Character : Creature, IDamageable
    {
        private float _hp;

        public float GetHp()
        {
            return _hp;
        }

        public float SetHp(float value)
        {
            if (value < 0)
                value = 0;

            _hp = value;
        }
        public void Damage(float amount)
        {
            _hp = amount;
        }

        public abstract void UniqueSkill(); // 추상함수는 정의하지않고 선언만 함.

    }
}
