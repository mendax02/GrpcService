using StandardProxyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeSession = TradingSession.Session;
            var newTrade = new NewTrade(tradeSession);
            var newOrder = new NewOrder(TradingSession.Session);
        }
    }
}
