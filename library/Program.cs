using library;

Book book = new Book();

// This is info for the book class
book.Title = "C# for Beginners";
book.Author = "Bill Gates";
book.ISBN = 12345678;
book.DisplayInfo();

// Add another book 
Book book2 = new Book();

book2.Title = "Methods and Classes";
book2.Author = "Microsoft";
book2.ISBN = 87654321;
book2.DisplayInfo();
