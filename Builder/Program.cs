using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var builder = new CharacterBuilder();
            var director = new BuilderDirector(builder);

            //  воин
            Console.WriteLine("\n1. СОЗДАНИЕ ВОИНА:");
            var warrior = director.CreateWarrior("Артур", 10)
                .SetWeapon("Двуручный меч")
                .SetArmor("Латная броня")
                .GetCharacter();
            warrior.Display();

            //  NPC
            Console.WriteLine("\n2. СОЗДАНИЕ ДРУЖЕЛЮБНОГО NPC:");
            var friendlyNPC = director.CreateNPC("Старый мудрец", CharacterClass.Mage, "советник")
                .SetWeapon("Посох")
                .GetCharacter();
            friendlyNPC.Display();

            
            

            Console.ReadKey();
        }
    }
}