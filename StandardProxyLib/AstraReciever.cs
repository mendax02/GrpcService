using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    class AstraReciever : IAstraReciever
    {
        private readonly IStandardMessage message;

        public AstraReciever(IStandardMessage message)
        {
            this.message = message;
        }
    }
}
