using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicClass
{
    class TextConsAdvent
    {
        static void Main(string[] args)
        {
            Units Hero = new Units();
            Hero.Set_Name("Hero");
            Hero.Set_Stats(5, 100, 100, 15, 10, 50);
            Hero.Show_Stats_Debug();
            Hero.Up_Level();
            Hero.Show_Stats_Debug();
            Hero.Up_Level(5);
            Hero.Show_Stats_Debug();
            Hero.Heal_Life(15);
            Hero.Restore_Mana(15);
            Hero.Show_Stats_Debug();
            Hero.Reset_Stats();
            Hero.Show_Stats_Debug();


            

        }
    }
}
