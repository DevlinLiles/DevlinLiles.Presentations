using System;
using System.Collections.Generic;
using Domain;

namespace UI.Models
{
    public class GameModel
    {

        public GameModel()
        {
            Players = new List<Player>();
            Locations = new List<Location>();
        }
        public List<Player> Players { get; set; }
        public List<Location> Locations { get; set; }
    }
}
