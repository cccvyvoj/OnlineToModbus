using System;
using System.IO;
using System.Text.Json;

namespace OnlineToModbusLibrary
{
    public class Kernel
    {
        public Kernel()
        {
            Config conf = new Config();
            try
            {
                conf = JsonSerializer.Deserialize<Config>(File.ReadAllText($"{AppContext.BaseDirectory}Config.json"));
            }
            catch (Exception ex)
            {
                //Log.Error($"Chyba čtení parametrů měřičů.{Environment.NewLine}{ex.Message}");
            }
            ModbusTCPServer server = new ModbusTCPServer(conf);
        }
    }
}
