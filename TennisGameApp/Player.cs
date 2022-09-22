using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TennisGameApp
{
    public class Player
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int levelPlayer { get; set; }
        public Player() { 
        }
        public Player(string name, string surname, int levelPlayer)
        {
            this.name = name;
            this.surname = surname;
            this.levelPlayer = levelPlayer;
        }
        public static string printPlayer(Player player) {
           return JsonSerializer.Serialize(player);   
        }
    }
}
