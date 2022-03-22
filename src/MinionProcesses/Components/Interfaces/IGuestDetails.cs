using MinionProcesses.Components.Enums;

namespace MinionProcesses.Components.Interfaces
{
    public interface IGuestDetails
    {
        GuestHypervisor Hypervisor { get; set; }

        GuestArchitecture Architecture { get; set; }

        GuestChipset Chipset { get; set; }

        string? EmulatorPath { get; set; }

        string? FirmwarePath { get; set; }
    }
}