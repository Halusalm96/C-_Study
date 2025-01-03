﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Instance
{
    class Barbarian
    {
        private uint Level;
        private uint Exp;
        private uint Hp;
        private bool IsAlive;

        private uint Movement_Speed;
        private uint Attack_Power;
        private string Name;

        private float PositionX;
        private float PositionY;

        public Barbarian(bool isPrintStat = true)
        {
            Level = 1;
            Exp = 0;
            Hp = 500;
            IsAlive = true;

            Movement_Speed = 10;
            Attack_Power = 10;

            Name = "바바리안";

            PositionX = 0;
            PositionY = 0;

            if (isPrintStat) PrintStat();
        }

        public Barbarian(float positionX, float positionY) : this(false)
        {
            PositionX = positionX;
            PositionY = positionY;

            PrintStat();
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Attack(uint gainExp)
        {
            Exp += gainExp;
        }

        public uint Damage(uint damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                IsAlive = false;
            }

            return Level * 2; //공격하는 대상에게 리턴하는 경험처..
        }

        public void PrintStat()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Hp: {Hp}, Exp: {Exp}");
            Console.WriteLine($"PositionX: {PositionX}, PositionY: {PositionY}");
        }

        public uint GetAttack_Power()
        {
            return Attack_Power;
        }

        public uint GetMovement_Speed()
        {
            return Movement_Speed;
        }
    }
}
