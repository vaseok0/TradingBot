using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingBot.Models;

namespace TradingBot.ViewModel
{
    public class ViewParser
    {
        public void ViewBot(BObot bot)
        {
            bot.ValueFrame();
            bot.ValueSide();
            bot.ValueValute();
        }

    }
}
