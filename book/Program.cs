using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading;

namespace lab3
{
    public class Book
    {
        public string name;
        public string fio;
        public string text;
    }
    class Title : Book
    {
        private string title;
        public Title(string name)
        {
            title = name;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Название книги " + "'" + name + "'");
        }
    }
    class Author : Book
    {
        private string author;

        public Author(string fio)
        {
            author = fio;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Автор: " + fio);

        }

    }
    class Content : Book
    {
        private string content;
        public Content(string text)
        {
            content = text;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Жанр: " + text);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string F;
            string a, b, c;
            Console.WriteLine("Title: ");
            F = Console.ReadLine();
            a = Convert.ToString(F);
            Console.WriteLine("Author: ");
            F = Console.ReadLine();
            b = Convert.ToString(F);
            Console.WriteLine("Content: ");
            F = Console.ReadLine();
            c = Convert.ToString(F);

            Title obj1 = new Title(a);
            Author obj2 = new Author(b);
            Content obj3 = new Content(c);
            Console.ReadLine();
        }
    }
}
