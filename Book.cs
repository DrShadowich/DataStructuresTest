using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Book
    {
        #region VARIABLES
        private string _bookName;
        private int _lists;
        #endregion
        #region PROPERTIES
        public int Lists { get { return _lists; } }
        public string BookName { get { return _bookName; } }
        #endregion
        #region METHODS
        public void TakeBook()
        {
            Console.WriteLine($"Вы взяли книгу \"{_bookName}\" на {_lists} страниц.");
        }
        #endregion
        #region CONSTRUCTORS
        public Book(string bookName, int lists)
        {
            _bookName = bookName;
            _lists = lists;
        }
        public Book()
        {
            Console.WriteLine("Название книги: ");
            _bookName = Console.ReadLine();
            Console.WriteLine("Кол-во листов у книги: ");
            _lists = int.Parse(Console.ReadLine());
        }
        #endregion
    }
}
