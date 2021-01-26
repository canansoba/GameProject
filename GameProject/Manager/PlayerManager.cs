using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entitties;

namespace GameProject
{
    class PlayerManager
    {
        List<Player> players = new List<Player>();
        public void Add (List<Player> players)
        {
            foreach (var people in players)
            {
                Console.WriteLine(people.FirstName + " oyuncu listesine eklendi" +"\n"+"Oyuncu Adı: "+people.UserName);
            }
           
        }
        public void Update (Person player)
        {
            Console.WriteLine(player.FirstName+" "+player.LastName+" " + player.NationalityId+" " + "Oyuncu silindi.");

        }

        public void Delete (string NationalityId)
        {
            foreach (var player in players)
            {
                if (player.NationalityId == NationalityId)
                {
                    players.Remove(player);
                    Console.WriteLine(player.FirstName + "İsismli oyuncu sistemden silindi.");
                }
                else
                    Console.WriteLine("Sistemde böyle bir oyuncu bulunamadı");
            }
           
        }
    }
}
