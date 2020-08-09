using System;

namespace StandardProxyLib
{
    public class Message : IStandardMessage
    {
        public Message()
        {
                
        }
        public string GetMessage(int id)
        {
            return id + " Captured";
        }
    }
}
