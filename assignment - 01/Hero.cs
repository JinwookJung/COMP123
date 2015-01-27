using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment___01
{
    class Hero
    {
        //Q1
        private int strength;
        private int speed;
        private int health;


        //Q2
        public string name
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

        //Q3


        private void generateAbilities()
        {
            Random random = new Random();

            int strength = random.Next(1, 101);
            int speed = random.Next(1, 101);
            int health = random.Next(1, 101);


            Console.WriteLine(strength);
        }
        public void fight()
        {

            Random random = new Random();
            int randomNumber = random.Next(0, 6);
            hitAttempt(randomNumber);


            Console.WriteLine("Damage is {0}", hitDamage());
        }
        public bool hitAttempt(int getNumber)
        {

            Random random = new Random();
            int randomNumber = random.Next(0, 5);


            switch (randomNumber)
            {
                case 0:
                    return true;
                    break;
                case 1:
                    return false;
                    break;
                case 2:
                    return false;
                    break;
                case 3:
                    return false;
                    break;
                case 4:
                    return false;
                    break;
            }

        }
        private int hitDamage()
        {
            int damage;

            Random random = new Random();
            int randomNumber = random.Next(1, 7);

            damage = strength * randomNumber;
            return damage;
        }
        public void show()
        { 
            Console.WriteLine("Strength is {0},Speed is {1}, Health is {2}", strength, speed, health);
        }
    }
}
