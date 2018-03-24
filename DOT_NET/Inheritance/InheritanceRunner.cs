using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET.Inheritance
{
    public class InheritanceRunner
    {
        public static Man CreateMan()
        {
            Console.WriteLine("Creatinon of man:\nEnter name, age, weight, growth: ");

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int growth = int.Parse(Console.ReadLine());

            Man man = new Man(name, age, weight, growth);

            return man;
        }

        public static Student CreateStudent()
        {
            Console.WriteLine("Creatinon of student:\nEnter name, age, weight, growth, " +
                "year of education start, cource, number of group");

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int growth = int.Parse(Console.ReadLine());
            int yearOfEducationStart = int.Parse(Console.ReadLine());
            int cource = int.Parse(Console.ReadLine());
            int numberOfGroup = int.Parse(Console.ReadLine());

            Student student = new Student(name, age, weight, growth, yearOfEducationStart, cource, numberOfGroup);

            return student;
        }

        public static Author CreateAuthor()
        {
            Console.WriteLine("Creatinon of author:  name, surname, date of birthday");

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            DateTime dateOfBirthday = DateTime.Parse(Console.ReadLine());

            Author author = new Author(name, surname, dateOfBirthday);

            return author;
        }

        public static Book CreateBook(Author author)
        {
            Console.WriteLine("Creatinon of book:\nCount of pages, " +
                "name of plishing office, date of publishing, date of book writing");

            int countOfPages = int.Parse(Console.ReadLine());
            string nameOfpuPlishingOffice = Console.ReadLine();
            DateTime dateOfPublishing = DateTime.Parse(Console.ReadLine());
            DateTime dateOfBookWriting = DateTime.Parse(Console.ReadLine());

            Book book = new Book(author, countOfPages, nameOfpuPlishingOffice, dateOfPublishing, dateOfBookWriting);

            return book;
        }

        public static void run()
        {
            Console.WriteLine("Create Man:\n");
            Man man = CreateMan();
            Console.WriteLine(man.ToString());

            Console.WriteLine("Create Student:\n");
            Student student = CreateStudent();
            Console.WriteLine(student.ToString());

            Console.WriteLine("Create Author:\n");
            Author author = CreateAuthor();
            Console.WriteLine(author.ToString());

            Console.WriteLine("Create Book:\n");
            Book book = CreateBook(author);
            Console.WriteLine(book.ToString());
        }
    }
}
