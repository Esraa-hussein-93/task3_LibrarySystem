using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    internal class Program
    {


        class Book
        {
            string title;
            string author;
            long isbn;
            bool avalability;


            public Book(string title = "none", string author = "none", long isbn = 0000, bool avalability = true)
            {
                this.title = title;
                this.author = author;
                this.isbn = isbn;
                this.avalability = avalability;
            }
            public string GetTitle()
            {
                return title;
            }
            public string GetAuthor()
            {
                return author;
            }
            public long GetIsbn()
            {
                return isbn;
            }
            public bool GetAvailability()
            {
                return avalability;
            }
            public void SetTitle(string BookTitle)
            {
                this.title = BookTitle;
            }
            public void SetAuthor(string BookAuthor)
            {
                this.author = BookAuthor;
            }
            public void SetIsbn(long isbnNumber)
            {
                this.isbn = isbnNumber;
            }
            public bool SetAvailability(string status)
            {
                if (status == "yes")
                {
                    this.avalability = true;
                    return true;
                }
                else if (status == "no")
                {
                    this.avalability = false;
                    return false;
                }
                else return false;
            }

        }

        class Library
        {
            List<Book> books = new List<Book>();
            public void AddBook(Book newbook)
            {
                books.Add(newbook);
                Console.WriteLine($"Successfully added");
            }

            public bool Searchbook(string text)
            {
                bool status = false;
                
                if (books.Count == 0)
                { Console.WriteLine("list is empty, add some books!"); }
                else

                {
                    for (int i = 0; i < books.Count; i++)
                    {

                        if (books[i].GetTitle() == text || books[i].GetAuthor() == text)
                        {
                            status = true;
                            Console.WriteLine("Founded");

                        }
                        else
                        {
                            status = false;
                            Console.WriteLine("not Found");
                        }
                    }
                }
                return status;
            }

            public void PrintList()
            {
                if (books.Count == 0) { Console.WriteLine("no books in the list"); }
                else
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        Console.WriteLine($" title =   {books[i].GetTitle()},  Author =   {books[i].GetAuthor()}");
                        Console.WriteLine("_--------------_");
                    }

                }
            }
            public void FindBorrowedBook(string text)
            {

                if (books.Count == 0)
                {
                    Console.WriteLine("This List is Empty , please enter some books. ");
                    Console.WriteLine(" ");
                }
                else
                {
                    string finder;
                    finder = text;

                    bool flag = false;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (finder == books[i].GetTitle()) ;
                        {
                            flag = books[i].GetAvailability();

                        }

                        if (flag == false)
                        {
                            Console.WriteLine($" ({finder}) is Borrowed.");
                            Console.WriteLine();

                        }
                        else Console.WriteLine($" ({finder})  is Availabe . ");
                        Console.WriteLine();
                    }

                }

            }



            public void FindReturnBook(string text)
            {

                if (books.Count == 0)
                {
                    Console.WriteLine("This List is Empty , please enter some books. ");
                    Console.WriteLine(" ");
                }
                else
                {
                    string finder;
                    finder = text;

                    bool flag = false;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (finder == books[i].GetTitle()) ;
                        {
                            flag = books[i].GetAvailability();

                        }

                        if (flag == false)
                        {
                            Console.WriteLine($" ({finder}) is Rerurned.");
                            Console.WriteLine();

                        }
                        else Console.WriteLine($" ({finder})  is Borrowed . ");
                        Console.WriteLine();
                    }

                }

            }
            static void Main(string[] args)
                {
                Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 9780743273565);
                Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 9780061120084, false);
                Book book3 = new Book("How To program C#", " Paul , Harvy ", 1234567890 , false);
                //Console.WriteLine($" Book title is :  {book1.GetTitle()} , Book Author is :  {book1.GetAuthor()}, ISBN is : {book1.GetIsbn()}, Avalability is : {book1.GetAvailability()}");
                //Console.WriteLine();
                //Console.WriteLine(" --- --- --- --- --- --- --- --- ---");
                //Console.WriteLine($" Book title is :  {book2.GetTitle()} , Book Author is :  {book2.GetAuthor()}, ISBN is : {book2.GetIsbn()}, Avalability is : {book2.GetAvailability()}");
                //Console.WriteLine();
                //Console.WriteLine(" --- --- --- --- --- --- --- --- ---");
                //book1.SetIsbn(12021);
                //Console.WriteLine($" Book title is :  {book1.GetTitle()} , Book Author is :  {book1.GetAuthor()}, ISBN is : {book1.GetIsbn()}, Avalability is : {book1.GetAvailability()}");
                //Console.WriteLine();
                //Console.WriteLine(" --- --- --- --- --- --- --- --- ---");
                //Console.WriteLine($" Book title is :  {book3.GetTitle()} , Book Author is :  {book3.GetAuthor()}, ISBN is : {book3.GetIsbn()}, Avalability is : {book3.GetAvailability()}");
                //book3.SetAvailability("no");
                //Console.WriteLine();
                //Console.WriteLine($" Book title is :  {book3.GetTitle()} , Book Author is :  {book3.GetAuthor()}, ISBN is : {book3.GetIsbn()}, Avalability is : {book3.GetAvailability()}");
                //Console.WriteLine(" --- --- --- --- --- --- --- --- ---");

                // =====================================================
                Library library = new Library();

                Library library1 = new Library();
                library1.AddBook(  new Book("Hot To program C#", " Paul , Harvy ", 1234567890, false));
                library1.AddBook(new Book("esraa", "Mohamed", 19932502, true));
                            
                            //Console.WriteLine("Please enter the book Title");
                            //string booktitle = Console.ReadLine();
                            //Console.WriteLine("Please enter the Autor name");
                            //string authorname = Console.ReadLine();
                            //Console.WriteLine("enter the ISBN number");
                            //long isbnNo = long.Parse(Console.ReadLine());
                            Console.WriteLine("please enter  the Auther name or the Book title To check if it is available");
                            string text = Console.ReadLine();
                           library1.FindBorrowedBook(text);
                            library1.FindReturnBook(text);

                     
                }

            }

       
    }
}
