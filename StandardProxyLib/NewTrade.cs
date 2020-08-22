using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    public class NewTrade : INewTrade
    {
        private readonly ITradeSession _session;

        public NewTrade(ITradeSession session)
        {
            _session = session;
        }
    }
}
