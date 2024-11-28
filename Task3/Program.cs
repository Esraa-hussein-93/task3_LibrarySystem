namespace Task3
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

        public void Addbook(Book newbook)
        {
            books.Add(newbook);
            Console.WriteLine($"{newbook.GetTitle()} added Succsessfully");
        }
        public bool Searchbook(string text)
        {
            bool status = false;

            if (books.Count == 0)
            { Console.WriteLine("list is empty, add some books!"); }
            else

            {
                Console.WriteLine("please enter the Author name or The Title ");
                string textTosearch = Console.ReadLine();
                for (int i = 0; i < books.Count; i++)
                {

                    if (books[i].GetTitle() == textTosearch || books[i].GetAuthor() == textTosearch)
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
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                Library library = new Library();
                //-------- ------- -------- ---------- --------- 
                Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 9780743273565);
                Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 9780061120084, false);
                Book book3 = new Book("How To program C#", " Paul , Harvy ", 1234567890);
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

                /// ----- --- ----- --- ----- ---
                library.FindBorrowedBook("To Kill a Mockingbird");
                char selection = ' ';


                do
                {
                    Console.WriteLine(" --------------------------------- ");
                    Console.WriteLine(" Please select what you want to do ");
                    Console.WriteLine("A: To Add a new Book");
                    Console.WriteLine("S: To Search a book  by title or auther");
                    Console.WriteLine("F: To Find Borrowed Book");
                    Console.WriteLine("P: Print all the books");
                    Console.WriteLine("Q: Exit");
                    selection = char.ToUpper(char.Parse(Console.ReadLine()));
                    if (selection == 'A')
                    {
                        Console.WriteLine("Please enter the book Title");
                        string booktitle = Console.ReadLine();
                        Console.WriteLine("Please enter the Autor name");
                        string authorname = Console.ReadLine();
                        Console.WriteLine("enter the ISBN number");
                        long isbnNo = long.Parse(Console.ReadLine());
                        Book book = new Book(booktitle, authorname, isbnNo, true);
                        library.Addbook(book);
                    }
                    else if (selection == 'S')
                    {
                        library.Searchbook("text");
                    }
                    else if (selection == 'P')
                    {
                        library.PrintList();
                    }
                    else if (selection == 'F') //
                    {
                    Console.WriteLine("please enter a book title or an Aythor name");
                    string text = Console.ReadLine();
                        library.FindBorrowedBook(text);
                    }
                }
                while (selection != 'Q');



            }
        }

    /// انا بحاول احسن الكود في console 
    /// بس محتاجة شوية وقت  لاني كنت محتاجة اسمع المحاضرات كتير 
    /// 
    

    }

