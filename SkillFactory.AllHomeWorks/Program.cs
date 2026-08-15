using SkillFactory.AllHomeWorks.AppContext;
using SkillFactory.AllHomeWorks.PreparForTable;
using SkillFactory.AllHomeWorks.Repositorys;

using (var db = new MyAppContext())
{
    var bookRepository = new BookRepository(db);
    var userRepository = new UserRepository(db);

    var allUsers = userRepository.GetAllUsers();
    foreach (var user in allUsers)
    {
        Console.WriteLine(user.Name);
    }
    bookRepository.AddBook(new Books { YearOfRelease = 1965, Author = "Tomas", BookGenre = "Horor", BookTitle = "IT" });
    bookRepository.AddBook(new Books { YearOfRelease = 2000, Author = "Alise", BookGenre = "Horor", BookTitle = "WTF" });
    var listbooks = bookRepository.GetAllBooks();

    foreach (var book in listbooks)
    {
        Console.WriteLine($"id {book.Id} Автор {book.Author} название {book.BookTitle}" );
    }
}