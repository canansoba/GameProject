using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entitties;

namespace GameProject.Manager
{
    class CampaignManager
    {
        List<Game> games = new List<Game>();
        public void Add(string GameName, ICampaignManager campaign)
        {
            foreach ( var game in games)
            {
                if(game.GameName ==GameName)
                {
                    campaign.Add(game);
                }
            }
        }

        
    }
}
