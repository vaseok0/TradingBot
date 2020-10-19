using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingBot.Models
{
    public class BObot
    {
        private Random rnd = new Random();

        public BObot()
        {
            Valute = ValueValute();
            Side = ValueSide();
            Frame = $"На {ValueFrame()} минут";
            VisibleTime = ValueTime();
        }
        public string Valute { get; set; }

        public string Frame { get; set; }

        public string Side { get; set; }

        public int VisibleTime { get; set; }


        public int ValueTime()
        {
            var item = rnd.Next(20000, 120000);
            return item;
        }

        public string ValueValute()
        {
            var valute = "";
            var item = rnd.Next(1, 10);
            switch (item)
            {
                case 1:
                    valute = "EUR/USD";
                    break;
                case 2:
                    valute = "AUD/CAD";
                    break;
                case 3:
                    valute = "EUR/CAD";
                    break;
                case 4:
                    valute = "AUD/USD";
                    break;
                case 5:
                    valute = "AUD/JPY";
                    break;
                case 6:
                    valute = "EUR/CHF";
                    break;
                case 7:
                    valute = "USD/CAD";
                    break;
                case 8:
                    valute = "USD/JPY";
                    break;
                case 9:
                    valute = "EUR/GBP";
                    break;
                case 10:
                    valute = "GBP/USD";
                    break;
            }

            return valute;
        }
        public string ValueSide()
        {
            string side;
            var item = rnd.Next(1, 10);
            if (item%2 == 0)
                side = "Вверх";
            else
                side = "Вниз";

            return side;
        }

        public int ValueFrame()
        {
            var item = rnd.Next(1, 10);

            switch (item)
            {
                case 1:
                     return 5;
                case 2:
                    return 10;
                case 3:
                    return 15;
                case 4:
                    return 20;
                case 5:
                    return 25;
                case 6:
                    return 30;
                case 7:
                    return 40;
                case 8:
                    return 45;
                case 9:
                    return 50;
                default:
                    return 60;
            }

        }
    }
}
