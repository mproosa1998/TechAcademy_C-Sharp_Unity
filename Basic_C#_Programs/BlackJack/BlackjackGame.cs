using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackjackGame : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack Players:");
            base.ListPlayers();
        }
    }
}
