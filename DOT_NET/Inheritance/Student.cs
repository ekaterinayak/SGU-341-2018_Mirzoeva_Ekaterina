using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET.Inheritance
{
    public class Student : Man
    {
        private int yearOfEducationStart;
        private int cource;
        private int numberOfGroup;

        public Student(): base() { }

        public Student(string name, int age, double weight,
                       int growth, int yearOfEducationStart, int cource, int numberOfGroup) : base(name, age, weight, growth)
        {
            YearOfEducationStart = yearOfEducationStart;
            Course = cource;
            NumberOfGroup = numberOfGroup;
        }

        public int YearOfEducationStart
        {
            get
            {
                return yearOfEducationStart;
            }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new InvalidDataException("year of education start can't be in future");
                }
                yearOfEducationStart = value;
            }     
        }

        public int Course
        {
            get
            {
                return cource;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("course can't be negative or 0");
                }
                cource = value;
            }
        }

        public int NumberOfGroup
        {
            get
            {
                return numberOfGroup;
            }
            set
            {
                if (value <= 0 || value > 999)
                {
                    throw new InvalidDataException("invalid number of group");
                }
                numberOfGroup = value;
            }
        }

        override public string ToString()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, growth: {Growth}, " +
                $"year of education start: {YearOfEducationStart}, cource: {Course}, number of group: {NumberOfGroup}";
        }
    }
}
