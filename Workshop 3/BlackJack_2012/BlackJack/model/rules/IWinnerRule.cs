﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IWinnerRule
    {
        bool IsDealerWinner(Player player, Dealer dealer, int maxScore);
    }
}
