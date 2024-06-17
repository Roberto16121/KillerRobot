using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerRobot
{
    public class LifeForm
    {
        protected static Random random = new();
        protected double Health;
        public bool IsAlive = true;
        public LifeFormType Type { get; set; }

        public double GetHealth()
        {
            return Health;
        }

        virtual public void TakeDamage(double damage)
        {
            Health -= damage;
            if(Health <= 0)
                IsAlive = false;  
        }
    }

    public class Animal : LifeForm
    {
        public Animal()
        {
            Health = random.Next(1, 10);
            Type = LifeFormType.Animal;
        }
    }

    public class Human : LifeForm
    {
        protected double Armor;

        public Human()
        {
            Health = random.Next(10, 100);
            Armor = random.Next(1, 10);
            Type = LifeFormType.Human;
        }

        public override void TakeDamage(double damage)
        {
            Health -= (damage - Armor);
            if(Health <= 0)
                IsAlive = false;
        }
    }

    public class Superhero : Human
    {
        public Superhero()
        {
            Health = random.Next(50, 200);
            Armor = random.Next(10, 50);
            Type = LifeFormType.Superhero;
        }
    }
    
}
