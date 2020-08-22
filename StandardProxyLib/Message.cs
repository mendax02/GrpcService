using NLog;
using System;

namespace StandardProxyLib
{
    public class Message : IStandardMessage
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Message()
        {
                
        }
        public string GetMessage(int id)
        {
            logger.Debug($"Recieved id {id}");
            logger.Trace($"Recieved id {id}");
            return id + " Captured";
        }
    }
}
