using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    public class TBLSession : ITradeSession
    {
        public ITradeSession TBLInstance {get; }
        public TBLSession()
        {
            TBLInstance = CreateTBLInstance();
        }

        private ITradeSession CreateTBLInstance()
        {
            throw new NotImplementedException();
        }
    }
}
