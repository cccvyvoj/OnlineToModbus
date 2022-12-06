using OnlineToModbusLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace OnlineToModbusService
{
    public partial class Service : ServiceBase
    {
        public Service()
        {           
            InitializeComponent();
            this.ServiceName = "OnlineToModbus";
            this.EventLog.Log = "OnlineToModbus";
        }

        protected override void OnStart(string[] args)
        {
            Task.Run(() =>
            {
                Kernel ker = new Kernel();
            });
        }

        protected override void OnStop()
        {
        }
    }
}
