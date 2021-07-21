using System;

namespace PostRequest
{
    public class ChangeUserState
    {
        public Guid id { get; set; }

        public string to { get; set; }

        public string method { get; set; }

        public string uri { get; set; }

        public string type { get; set; }
        
        public string  resource { get; set; }



    }
}
