using EasyModbus;
using EasyModbus.Exceptions;
using OnlineToModbusLibrary.LonDataReference;
using System;
using System.Data;
using System.ServiceModel;

namespace OnlineToModbusLibrary
{
    public class ModbusTCPServer
    {
        public ModbusTCPServer()
        {
            LonDataClient client;

            BasicHttpBinding binding = new BasicHttpBinding();
            //Specify the address to be used for the client.
            EndpointAddress address = new EndpointAddress("http://192.168.111.62:8881/LonDataService");
            // Create a client that is configured with this address and binding.
            client = new LonDataClient(binding, address);
            client.Open();
            ModbusServer server = new ModbusServer();
            server.Listen();
            while (true)
            {
                //registr s casem
                server.holdingRegisters[6] = (short)DateTime.Now.Second;

                //celkova spotreba
                string valuestring =  client.GetValue("E133", "nvoTotWhImp", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine(valuestring);
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d/1000);
                    server.holdingRegisters[2] = (short)(value >> 16);
                    server.holdingRegisters[1] = (short)(value & 0xFFFF);
                }
                //aktualni vykon
                valuestring = client.GetValue("E133", "nvoActPowerSum", "");
                d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine(valuestring);
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[4] = (short)(value >> 16);
                    server.holdingRegisters[3] = (short)(value & 0xFFFF);
                }
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
