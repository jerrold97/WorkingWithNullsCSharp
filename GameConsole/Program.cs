using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Sarah" },
            //    new PlayerCharacter(),
            //    null
            //};

            PlayerCharacter[] players = null;
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
            Console.ReadLine();
        }
        /*
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            //player.Name = " ";
            //player.DaysSinceLastLogin = 42;
            //PlayerCharacter player = null;
            player.DaysSinceLastLogin = 42;
            int days = player?.DaysSinceLastLogin ?? -1;

            //int days = player.DaysSinceLastLogin ?? -1;
            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);
            //PlayerDisplayer.Write(player);
            Console.ReadLine();
        }
        */
    }
}
