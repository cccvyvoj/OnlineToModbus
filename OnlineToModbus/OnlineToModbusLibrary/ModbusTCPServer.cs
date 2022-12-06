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
        public ModbusTCPServer(Config conf)
        {
            LonDataClient client;

            BasicHttpBinding binding = new BasicHttpBinding();
            //Specify the address to be used for the client.
            EndpointAddress address = new EndpointAddress($"http://{conf.IPAdresa}:8881/LonDataService");
            // Create a client that is configured with this address and binding.
            client = new LonDataClient(binding, address);
            client.Open();
            ModbusServer server = new ModbusServer();
            server.Listen();
            while (true)
            {
                //registr s casem
                server.holdingRegisters[0] = (short)DateTime.Now.Second;
                switch (conf.Server)
                {
                    case "Biomedica":
                        Biomedica(client, server);
                        break;
                    case "Kimm":
                        Kimm(client, server);
                        break;
                    default:
                        break;
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        private static void Biomedica(LonDataClient client, ModbusServer server)
        {

            //Elektromer fotovoltaika Farmablok
            try
            {
                //celkova spotreba
                string valuestring = client.GetValue("E125", "nvoTotWhImp", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[1] = (short)(value & 0xFFFF);
                    server.holdingRegisters[2] = (short)(value >> 16);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.holdingRegisters[1] = 0;
                server.holdingRegisters[2] = 0;
            }
            try
            {
                //aktualni vykon
                string valuestring = client.GetValue("E125", "nvoActPowerSum", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[3] = (short)value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.holdingRegisters[3] = 0;
            }

            //Elektromer fotovoltaika Sklad33
            try
            {
                //celkova spotreba
                string valuestring = client.GetValue("E137", "nvoTotWhImp", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[4] = (short)(value & 0xFFFF);
                    server.holdingRegisters[5] = (short)(value >> 16);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.holdingRegisters[4] = 0;
                server.holdingRegisters[5] = 0;
            }
            try
            {
                //aktualni vykon
                string valuestring = client.GetValue("E137", "nvoActPowerSum", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[6] = (short)value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.holdingRegisters[6] = 0;
            }
        }

        private static void Kimm(LonDataClient client, ModbusServer server)
        {

            //Elektromer fotovoltaika Vodarna
            try
            {
                Console.WriteLine("Vodarna:");
                //celkova spotreba
                string valuestring = client.GetValue("E124", "nvoTotWhImp", "");
                decimal d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[1] = (short)(value & 0xFFFF);
                    server.holdingRegisters[2] = (short)(value >> 16);
                }
                //aktualni vykon
                valuestring = client.GetValue("E124", "nvoActPowerSum", "");
                d = Decimal.Parse(valuestring, System.Globalization.NumberStyles.Float);
                Console.WriteLine($"\t{valuestring}");
                if (valuestring != "--")
                {
                    Int32 value = Convert.ToInt32(d / 1000);
                    server.holdingRegisters[3] = (short)value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.holdingRegisters[1] = 0;
                server.holdingRegisters[2] = 0;
            }
        }
    }
}
