using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Manager;
using GameProject.Entitties;

namespace GameProject.Manager
{
    class GameManager
    {
        List<Game> games = new List<Game>();
        public void Add (Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " Oyunu sisteme eklendi.");
        }
        public void Update (Game game)
        {
            Console.WriteLine("Oyun güncellendi.");
        }
        public void Delete (List<Game> games)
        {
           /* foreach (var game in games)
            {
                games.Remove(game);
                Console.WriteLine(game.GameName + " - Oyun sistemden silinmiştir.");
            }*/
        }
        public void Sell(List<Game> games,List<Player> players)
        {
            foreach (var player in players)
            {
                foreach (var game in games)
                {             
                        Console.WriteLine(player.UserName+ " tarafından "+game.GameName+" satın aldı");               
                }
            }
        }
        public void CompainGame (List<Game> games,string GameName, ICampaignManager campaign)
        {
            foreach (var game in games)
            {
                if(game.GameName == GameName)
                {
                    int ilkFiyat=game.GamePrice;
                    campaign.Add(game);
                    Console.WriteLine(game.GameName + " "+ "Ürününüzün ilk fiyatı: " + ilkFiyat+ "\n"+ "İndirimli Fiyatı : " +game.GamePrice);
                }
            }
        }
    }
}
