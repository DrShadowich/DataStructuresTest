using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    abstract class Spell
    {
        protected string _spellsName;
        public string SpellsName { get { return _spellsName; } }
        public virtual void Cast()
        {
            Console.WriteLine("Произошло заклинание");
        }
    }
}
