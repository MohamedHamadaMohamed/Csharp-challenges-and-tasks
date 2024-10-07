using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Library
    {
        List<Book> collection;

        public Library()
        {
            this.collection = new List<Book>();
        }
        public void AddBook(Book book)
        {
            collection.Add(book);
        }
        public bool SearchBook(string str)
        {
            bool flag = false;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Title == str || collection[i].Author == str)
                {
                    flag = true;
                    Console.WriteLine("the Book exist");
                    return flag;
                }
            }
            Console.WriteLine("the Book do not exist");

            return flag;
        }
        public bool BorrowBook(string str)
        {
            bool flag = false;

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Title == str || collection[i].Author == str)
                {
                    if (collection[i].Availabitiy == true)
                    {
                        collection[i].Availabitiy = false;
                        flag = true;
                        Console.WriteLine("you can bollow this book");
                        return flag;
                    }
                    else
                    {
                        Console.WriteLine("you can't bollow this book ,already borrowed");
                        return false;
                    }
                }

            }

            Console.WriteLine("this book is not exist in the library");
            return flag;
        }
        public bool ReturnBook(string str)
        {
            bool flag = false;

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Title == str || collection[i].Author == str)
                {
                    collection[i].Availabitiy = true;
                    Console.WriteLine($"the book : {str} returned done");
                    return true;
                }
            }
            Console.WriteLine("this book don't Belong to this library");
            return false;
        }
    }
}
