using System;
using System.Collections.Generic;
using System.Text;

namespace StandardProxyLib
{
    class AstraPublisher: IAstraPublisher
    {
        private readonly IStandardMessage message;

        public AstraPublisher(IStandardMessage message)
        {
            this.message = message;
        }

    }
}
