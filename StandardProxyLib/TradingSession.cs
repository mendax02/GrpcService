using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    public sealed class TradingSession : ITradeSession
    {
        private static readonly TradingSession instance = new TradingSession();

        static TradingSession() { }
        private TradingSession()
        {
          
        }

        public static TradingSession Session
        {
            get
            {
                return instance;
            }
        }


    }
}
