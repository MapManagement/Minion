using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class PciDevice : IPciDevice
    {
        public string? Driver { get; set; }
        public string? Domain { get; set; }
        public string? Bus { get; set; }
        public string? Slot { get; set; }
        public string? Function { get; set; }
    }
}