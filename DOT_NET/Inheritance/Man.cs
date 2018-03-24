using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOT_NET.Inheritance
{
    public class Man
    {
        private string name;
        private int age;
        private double weight;
        private int growth;

        public Man() { }

        public Man(string name, int age, double weight, int growth)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Growth = growth;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                for (int number = 0; number < 10; number++)
                {
                    if (value.Contains(number.ToString()))
                    {
                        throw new InvalidDataException("Name of man can't contains number");
                    }
                    name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("age can't be negative value");
                }
                age = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("weight can't be negative value");
                }
                weight = value;
            }
        }

        public int Growth
        {
            get
            {
                return growth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("growth can't be negative value");
                }
                growth = value;
            }
        }
        override public string ToString()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, growth: {Growth}";
        }
    }
}
