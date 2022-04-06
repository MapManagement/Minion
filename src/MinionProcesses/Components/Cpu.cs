using System;
using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class Cpu : ICpu
    {
        #region Constructor

        public Cpu()
        {

        }

        #endregion

        #region Properties

        public CpuConfiguration Configuration { get; set; }
        public bool CopyHostCpuConfiguration { get; set; }
        public bool SecurityFlawMigations { get; set; }
        public int Sockets { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }

        #endregion
    }
}