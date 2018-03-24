using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET.Inheritance
{
    public class Author
    {
        private string name;
        private string surname;
        private DateTime dateOfBirthday;

        public Author() { }

        public Author(string name, string surname, DateTime dateOfBirthday)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = dateOfBirthday;
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
                }
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                for (int number = 0; number < 10; number++)
                {
                    if (value.Contains(number.ToString()))
                    {
                        throw new InvalidDataException("Surname of man can't contains number");
                    }
                }
                surname = value;
            }
        }
        public DateTime DateOfBirthday
        {
            get
            {
                return dateOfBirthday;
            }
            set
            {
                if (DateTime.Today <= value)
                {
                    throw new InvalidDataException("Author's birthday can't be in a future");
                }
                dateOfBirthday = value;
            }
        }

        override public string ToString()
        {
            return $"Name: {Name}, surname: {Surname}, date of birthday: {DateOfBirthday}";
        }
    } 
}
