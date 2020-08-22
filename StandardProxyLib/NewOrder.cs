using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    public class NewOrder: INewOrder
    {
        private readonly ITradeSession _session;

        public NewOrder(ITradeSession session)
        {
            _session = session;
        }
    }
}
