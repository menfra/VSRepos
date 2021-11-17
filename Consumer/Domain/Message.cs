using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Message
    {
        private static readonly Message instance = null;
        public static Message GetInstance
        {
            get
            {
                if (instance == null) return new Message();
                return instance;
            }
        }

        public string Name { get; set; } = "Frank";
    }
}
