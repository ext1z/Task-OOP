

//3.Создайте класс Library, который будет хранить информацию о книгах. Класс должен содержать список книг (с использованием коллекции List<Book>).
//Создайте класс Book, который имеет поля:

//название(string),
//автор(string),
//год издания(int).
//Добавьте методы в Library для добавления книг, удаления книги и отображения информации о всех книгах.

//Примените композицию для представления библиотеки как собрания книг, а также создайте несколько объектов библиотеки и книг в методе Main().



Library library = new Library();
Book book1 = new Book(2,"Book1", "Qwe", 1222);
Book book2 = new Book(3, "Book1", "Qwe", 1222);
Book book3 = new Book(4, "Book1", "Qwe", 1222);
Book book4 = new Book(5, "Book1", "Qwe", 1222);

library.CreateBook(book1);
library.CreateBook(book2);
library.CreateBook(book3);
library.CreateBook(book4);


foreach (Book book in library.GetBooks())
{
    Console.WriteLine($"Id: {book.Id} Name : {book.Name} Author: {book.Author} Year: {book.YearOfPublication}");
}


library.DeleteBookById(2);

foreach (Book book in library.GetBooks())
{
    Console.WriteLine($"Id: {book.Id} Name : {book.Name} Author: {book.Author} Year: {book.YearOfPublication}");
}



public class Library
{
    private readonly List<Book> _books;


    public Library()
    {
        _books = new List<Book>();
    }



    public void CreateBook(Book book)
    {
        _books.Add(book);
    }


    public List<Book> GetBooks()
    {
        return _books;
    }

    public void DeleteBookById(int id)
    {
        
        Book? book = _books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            _books.Remove(book);
            Console.WriteLine("Книга удалена");
        }
        else
        {
            Console.WriteLine("Книга не найдена");
        }
    }
}



public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public int YearOfPublication { get; set; }
    public Book(int id, string name, string author, int yearOfPublication)
    {
        Id = id;
        Name = name;
        Author = author;
        YearOfPublication = yearOfPublication;
    }
}