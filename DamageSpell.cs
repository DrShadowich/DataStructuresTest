using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class DamageSpell : Spell
    {
        #region VARIABLES
        private int _damage;
        private string _spellsType;
        #endregion
        #region PROPERTIES
        public string SpellsType { get { return _spellsType; } }
        public int Damage { get { return _damage; } }
        #endregion
        #region METHODS
        public override void Cast()
        {
            Console.WriteLine($"Произошло убийственное заклинание \"{_spellsName}\" техникой \"{_spellsType}\", " +
                $"нанеся {_damage} урона.");
        }
        #endregion
        #region CONSTRUCTORS
        public DamageSpell()
        {
            Console.WriteLine("Урон заклинания: ");
            _damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип заклинания: ");
            _spellsType = Console.ReadLine();
            Console.WriteLine("Название заклинания: ");
            _spellsName = Console.ReadLine();
        }
        public DamageSpell(int damage, string spellsType, string spellsName)
        {
            _damage = damage;
            _spellsName = spellsName;
            _spellsType = spellsType;
        }
        #endregion
    }
}
