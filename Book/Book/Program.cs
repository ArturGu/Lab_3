using System;

namespace Book
{
    class Book
    {
        public Book()
        {
            Console.Write("Введiть назву книги: ");
            string t = Console.ReadLine();

            Console.Write("Автор цiєї книги: ");
            string a = Console.ReadLine();

            Console.Write("Змiст книги: ");
            string c = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Ваша книга: ");

            Title title = new Title(t);
            title.Show();

            Author author = new Author(a);
            author.Show();

            Content content = new Content(c);
            content.Show();
        }        
    }

    public class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Назва: {title}");
        }
    }

    public class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Автор: {author}");
        }
    }

    public class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Зміст: {content}");            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
