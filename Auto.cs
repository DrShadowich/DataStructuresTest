using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    // Не имело ли смысл использовать struct вместо class?
    class Auto
    {
        #region VARIABLES
        private string _mark;
        private int _price;
        #endregion
        #region PROPERTIES
        public int Price { get { return _price; } }
        public string Mark { get { return _mark; } }
        #endregion
        #region CONSTRUCTORS
        public Auto()
        {
            Console.WriteLine("Марка автомобиля:");
            _mark = Console.ReadLine();
            Console.WriteLine("Цена автомобиля: ");
            _price = int.Parse(Console.ReadLine());
        }
        public Auto(string mark, int price)
        {
            _mark = mark;
            _price = price;
        }
        #endregion
    }
}
