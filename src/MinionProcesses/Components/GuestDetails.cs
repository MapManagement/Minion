using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class GuestDetails : IGuestDetails
    {
        public GuestHypervisor Hypervisor { get; set; }
        public GuestArchitecture Architecture { get; set; }
        public GuestChipset Chipset { get; set; }
        public string? EmulatorPath { get; set; }
        public string? FirmwarePath { get; set; }
    }
}