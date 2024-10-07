using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Book
    {
        

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availabitiy { get; set; }

        public Book(string title = "Unknown", string author = "Unknown", string iSBN = "Unknown", bool availabitiy = true)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availabitiy = availabitiy;
        }
    }
}
