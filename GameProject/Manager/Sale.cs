using GameProject.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class Sale : ICampaignManager
    {
        public void Add(Game game)
        {
            game.GamePrice = (int)(game.GamePrice-(game.GamePrice)*(0.20));
        }
    }
}
