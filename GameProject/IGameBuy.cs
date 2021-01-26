using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entitties;

namespace GameProject
{
    interface IGameBuy
    {
        void Add(Game game);
        void Delete(Game game);
        void Sell(List<Game> games, List<Player> players,List<Campaign> campaigns);
    }
}
