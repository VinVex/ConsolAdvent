using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClass
{
    /**
     *   Basic Setup for the Units, includes Living beings, Items, Weapons, Abilities and Skills.
     *   Uses five stats: HP = Life, MP = Mana, AGI = Agility, ATT = Attack, DEF = Defense
     *   Adds one special banner with the help of items: SP = Shield-Power
     * 
     * */
    //TODO: SKILLS!!
    public class Units
    {
        private string Unit_Name;
        private uint Unit_Level;

        private int Unit_Life;
        private int Unit_Mana;
        private int Unit_Agility;
        private int Unit_Attack;
        private int Unit_Defense;
        public Units()
        {
            
        }



        //TODO: Add use for ShieldPower
        //int Unit_Shield_Power;

        public void Set_Name(string name)
        {
            Unit_Name = name;
        }

        /**
         * 
         *  Set_Stats is for debugging purposes, can be used to create a cheat class that has upped stats but no abilites.
         *  To access Set_Stats from the menu, type: --< "IAMDAMOD" >--
         *  A series of nonsense question will be asked: --< "How old are you : _ " ; "How Manly are you: _ " ; "How much Einstein have you: _ "; "How much Cat have you in you: _ "; "Noodle or Manliness: _ "; "Manly Man or Superman: _ " >--
         * 
         **/

         

        public void Set_Stats(uint level, int life, int mana, int agility, int attack, int defense)
        {
            Unit_Level = level;
            Unit_Life = life;
            Unit_Mana = mana;
            Unit_Agility = agility;
            Unit_Attack = attack;
            Unit_Defense = defense;
        }

        //TODO: Add a function to add Abilities and Skills.

        /**
         *  Case the player wants to start anew, the class and all the items will be set to the basic of the class
         **/

        //TODO: Add a Reset for the different classes
        //TODO: Create a custom "Cheat" Reset Stat function

        public void Reset_Stats() //Standard
        {
            Unit_Level = 1;
            Unit_Life = 100;
            Unit_Mana = 25;
            Unit_Agility = 15;
            Unit_Attack = 20;
            Unit_Defense = 10;
        }
        //Level up by 1
        public void Up_Level()
        {
            Unit_Level++;
        }
        /**
         * For Debug process planned, add Level according to x.
         * To access this command, type: --< "GimmeDaLevel" >--
         * It will ask: --< "How many : _" >--
         **/

        public void Up_Level(uint x)
        {
            Unit_Level = Unit_Level + x;
        }
        //Heal the unit for X
        public void Heal_Life(int x)
        {
            Unit_Life += x;
        }
        public void Restore_Mana(int x)
        {
            Unit_Mana += x;
        }

        /**
         *  Show_Stats unformatted for debug use 
         * 
         **/
        
        public void Show_Stats_Debug()
        {
            Console.Out.WriteLine("Saved Stats as of now, DEBUG");
            Console.Out.WriteLine(Unit_Name);
            Console.Out.WriteLine(Unit_Level);
            Console.Out.WriteLine(Unit_Life);
            Console.Out.WriteLine(Unit_Mana);
            Console.Out.WriteLine(Unit_Agility);
            Console.Out.WriteLine(Unit_Attack);
            Console.Out.WriteLine(Unit_Defense);
        }
        
    }
    class Unit_Hero
    {
        //TODO: Set up classes and different Start stats
    }
    class Unit_Mob
    {
        //TODO: Set up RNG spawner that gives enemies according to the level of the player.
    }
    struct Items
    {
        string Item_Name;
        string Item_Description;
    }
    class Item
    {
        //TODO: Create basic items and special RNG rolled buff items.
    }
    class Weapon
    {
        //TODO: Set up small RNG to uniquify weapons.
        //
    }

    class Item_Ability
    {
        //TODO: Abilities, Weaponbound skills
    }
    enum ability
    {
        NONE = 0,
        Double_Attack = 1,
        Power_Slash = 2,
        Power_Strike = 3,
        Penetrating_Shot = 4
    }

    /**
     *  Sort of the rarity system of World of Warcraft
     *  
     **/

    //TODO: Add Color to the Console output if the weapons or item has some sort of rarity.
    enum ranking
    {
        Trash   = 0, //Grey     -> Japtem
        White   = 1, //White    -> Common
        Green   = 2, //Green    -> Uncommon
        Orange  = 4, //Orange   -> Rare
        Purple  = 5  //Purple   -> Superb Rare

    }
}
