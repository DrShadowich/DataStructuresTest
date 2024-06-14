using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{

    internal class MainProgram
    {
        static void FirstTask()
        {
            Queue<Spell> spells = new Queue<Spell>();

            spells.Enqueue(new DamageSpell());
            spells.Enqueue(new HealSpell(50, "супер лечение"));
            spells.Enqueue(new DamageSpell(1490217000, "анигиляция", "анигиляторная пушка"));
            spells.Enqueue(new DamageSpell(15, "обратное лечение", "обратно-лечитель"));
            spells.Enqueue(new HealSpell());
            int tempCount = spells.Count;
            for (int i = 0; i < tempCount; i++)
            {
                Spell spell = spells.Dequeue();
                spell.Cast();
            }
        }
        static void SecondTask()
        {
            Random randint = new Random();
            Stack<Book> booksShell = new Stack<Book>();
            booksShell.Push(new Book("Первая книга", 50));
            booksShell.Push(new Book("Сборник А. С. Пушкин", 351));
            booksShell.Push(new Book());
            booksShell.Push(new Book());
            booksShell.Push(new Book("Книга о книгах", randint.Next(1, 6351)));
            booksShell.Push(new Book("Последняя книга", randint.Next(1, 51321)));
            int tempCount = booksShell.Count;
            for(int i = 0; i < tempCount; i++)
            {
                Book book = booksShell.Pop();
                book.TakeBook();
            }
        }
        static void Main()
        {
            Random randint = new Random();
            Auto firstAuto = new Auto("БМВ X5 ULTRA", 250000);
            Auto secondAuto = new Auto("БМВ 10X 600", 1000000);
            Auto thirdAuto = new Auto("БМВ 50V", 500000);

            Auto fourthAuto = new Auto("Порш 15 0 10", 12000000);
            Auto fifthAuto = new Auto("Порш 50 X1", 5000000);
            Auto sixthAuto = new Auto("Порш 50 X2", 205000);

            Auto sevenAuto = new Auto("Ауди 51", randint.Next(250000, 15000000));
            Auto eighthAuto = new Auto("Ауди 260", randint.Next(250000, 15000000));
            Auto ninthAuto = new Auto("Ауди 10V9", randint.Next(250000, 15000000));

            List<Auto> theWholeAutos = new List<Auto>() 
            { 
                firstAuto, secondAuto, thirdAuto, 
                fourthAuto, fifthAuto, sixthAuto,
                sevenAuto, eighthAuto, ninthAuto 
            };

            List<Auto> firstAutos = new List<Auto>();
            List<Auto> secondAutos = new List<Auto>();
            List<Auto> thirdAutos = new List<Auto>();
            
            foreach(Auto auto in theWholeAutos)
            {
                string[] splittedMarkName = auto.Mark.Split(' ');
                foreach(string str in splittedMarkName)
                {
                    if (str == "БМВ") firstAutos.Add(auto);
                    else if (str == "Порш") secondAutos.Add(auto);
                    else if (str == "Ауди") thirdAutos.Add(auto);
                }
            }

            Dictionary<string, List<Auto>> autos = new Dictionary<string, List<Auto>>();
            autos["БМВ"] = firstAutos;
            autos["Порш"] = secondAutos;
            autos["Ауди"] = thirdAutos;
            Console.WriteLine("Какой марки хотите авто: ");
            string mark = Console.ReadLine();
            if(autos.ContainsKey(mark))
            {
                foreach (Auto auto in autos[mark])
                {
                    Console.WriteLine($"{auto.Mark} марки {mark} стоит {auto.Price}руб.");
                }
            }
        }
    }
}
