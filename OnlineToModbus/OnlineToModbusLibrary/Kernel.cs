using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineToModbusLibrary
{
    public class Kernel
    {
        public Kernel()
        {
            ModbusTCPServer server = new ModbusTCPServer();
        }
    }
}
