using MinionProcesses.Components.Enums;

namespace MinionProcesses.Components.Interfaces
{
    public interface ICpu
    {
        CpuConfiguration Configuration { get; set; }

        bool CopyHostCpuConfiguration { get; set; }

        bool SecurityFlawMigations { get; set; }

        int Sockets { get; set; }

        int Cores { get; set; }

        int Threads { get; set; }

    }
}