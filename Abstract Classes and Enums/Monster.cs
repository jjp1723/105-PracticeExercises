using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Enums
{
    enum Damage
    {
        Grass,
        Fire,
        Water,
        Ice,
        Earth
    }
    abstract class Monster
    {
        //Fields
        protected int health;
        protected Damage type;
        protected string name;
        protected Random rng;

        //Parameterized constructor
        public Monster(int hp, Damage tp, string id, Random rnj)
        {
            health = hp;
            type = tp;
            name = id;
            rng = rnj;
        }

        //Health property; sets by subtracting from current health value (never goes below 0)
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if(value > 0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }

        //Type property
        public Damage Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        //Name property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //RNG property
        public Random RNG
        {
            get
            {
                return RNG;
            }
            set
            {
                rng = value;
            }
        }

        //Abstract Attack method
        public abstract int Attack();

        //Overriding ToString method
        public override string ToString()
        {
            string basic = name + " has " + health + " health and ";

            string special = "";
            switch (type)
            {
                case Damage.Grass:
                    special = "ensnares enemies with plants";
                    break;
                case Damage.Fire:
                    special = "breathes fire on enemies";
                    break;
                case Damage.Water:
                    special = "hurls torrents of water at enemies";
                    break;
                case Damage.Ice:
                    special = "freezes enemies solid";
                    break;
                case Damage.Earth:
                    special = "throws large boulders at enemies";
                    break;
            }

            return basic + special;
        }
    }
}
