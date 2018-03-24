using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET.Inheritance
{
    public class Book
    {
        private Author author;
        private int countOfPages;
        private string nameOfpuPlishingOffice;
        private DateTime dateOfPublishing;
        private DateTime dateOfBookWriting;

        public Book() { }

        public Book(Author author)
        {
            this.Author = author;
        }

        public Book(Author author, int countOfPages, string nameOfpuPlishingOffice,
            DateTime dateOfPublishing, DateTime dateOfBookWriting) : this(author)
        {
            CountOfPages = countOfPages;
            NameOfpuPlishingOffice = nameOfpuPlishingOffice;
            DateOfPublishing = dateOfPublishing;
            DateOfBookWriting = dateOfBookWriting;
        }

        public Author Author { get; set; }

        public int CountOfPages
        {
            get
            {
                return countOfPages;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("count of pages can't be negative value or 0");
                }
                countOfPages = value;
            }
        }

        public string NameOfpuPlishingOffice
        {
            get
            {
                return nameOfpuPlishingOffice;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("name of plishing office cant't be empty");
                }
                nameOfpuPlishingOffice = value;
            }
        }
        public DateTime DateOfPublishing
        {
            get
            {
                return dateOfPublishing;
            }
            set
            {
                if (value <= author.DateOfBirthday)
                {
                    throw new InvalidDataException("date of publishing can't be equals or less than author birthday");
                }
                dateOfPublishing = value;
            }
        }

        public DateTime DateOfBookWriting
        {
            get
            {
                return dateOfBookWriting;
            }
            set
            {
                if (value <= author.DateOfBirthday)
                {
                    throw new InvalidDataException("date of publishing can't be equals or less than author birthday");
                }
                dateOfBookWriting = value;
            }
        }

        override public string ToString()
        {
            return $"Author: {Author.ToString()}, count of pages: {CountOfPages}" +
                $"name of plishing office: {NameOfpuPlishingOffice}, " +
                $"date of publishing: {DateOfPublishing}, date of book writing: {DateOfBookWriting}";
        }
    }
}
