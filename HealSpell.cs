using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class HealSpell : Spell
    {
        #region VARIABLES
        private int _healPower;
        #endregion VARIABLES
        #region PROPERTIES
        public int HealPower { get { return _healPower; } }
        #endregion
        #region METHODS
        public override void Cast()
        {
            Console.WriteLine($"Наколдовалось заклинание лечения \"{_spellsName}\", излечив {_healPower} здоровья.");
        }
        #endregion
        #region CONSTRUCTORS
        public HealSpell()
        {
            Console.WriteLine("Сила лечения: ");
            _healPower = int.Parse(Console.ReadLine());
            Console.WriteLine("Название заклинания: ");
            _spellsName = Console.ReadLine();
        }
        public HealSpell(int healPower, string spellsname)
        {
            _healPower = healPower;
            _spellsName = spellsname;
        }
        #endregion
    }
}
