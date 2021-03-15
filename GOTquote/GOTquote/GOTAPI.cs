using System;
using System.Collections.Generic;
using System.Text;

namespace GOTquote
{
    public class GOTAPI
    {
        public string quote { get; set; }
        public string character { get; set; }

        public GOTAPI()
        {
            quote = string.Empty;
            character = string.Empty;
        }
        public GOTAPI(string Quote, string Character)
        {
            Quote = quote;
            Character = character;
        }
        public override string ToString()
        {
            return $"{quote} - {character}";
        }

    }

    
}
