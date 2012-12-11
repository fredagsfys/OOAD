using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinsIfEqual : IWinnerRule
    {
        public bool IsDealerWinner(Player player, Dealer dealer, int maxScore)
        {
            if (player.CalcScore() > maxScore)
            {
                return true;
            }
            else if (dealer.CalcScore() > maxScore)
            {
                return false;
            }
            return dealer.CalcScore() > player.CalcScore();
        }
    }
}
