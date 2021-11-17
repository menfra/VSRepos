using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Producer.DataModels
{
    class GasNetWork : INetWork
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
