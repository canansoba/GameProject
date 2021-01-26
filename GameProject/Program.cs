using System;
using System.Collections.Generic;
using GameProject.Entitties;
using GameProject.Manager;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string TC;
            Campaign campaign = new Campaign();
            Game game = new Game();
            game.GameName ="oyun1";
            game.GamePrice = 105;        

            Player player = new Player();
            
            player.UserName ="sscc";
            player.Password ="sukran1";

          //  player.Id = 1;
            player.FirstName = "canan";
            player.LastName = "soba";
            player.NationalityId = "1234569852";
          //  player.DateOfBirth = DateTime.Today;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            PlayerManager playerManager = new PlayerManager();
            List<Game> games = new List<Game>() { game };
            List<Player> players = new List<Player>() { player};
            gameManager.Sell(games,players);
            playerManager.Add(players);
            ICampaignManager campaignManager = new Sale();
            gameManager.CompainGame(games,game.GameName,campaignManager);
            gameManager.Delete(games);
            
            //Console.WriteLine("Silmek istediğiniz kişinin TC Kimlik numarasını giriniz.");
            //TC = Convert.ToString(Console.ReadLine());
            //playerManager.Delete(TC);     
           
        }
    }
}
