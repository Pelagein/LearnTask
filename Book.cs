using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTask
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsRead { get; private set; }

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            IsRead = false;
    
    }

        public void MarkAsRead()
        {
            IsRead = true;
        }

        public override string ToString()
        {
            return ($"{Title} автора {Author} - {IsRead}");
        }

        public void Print()
        {
            if (IsRead) Console.WriteLine($"{Title} автора {Author} - Прочитно");
            else Console.WriteLine($"{Title} автора {Author}");
        }
    }
}
