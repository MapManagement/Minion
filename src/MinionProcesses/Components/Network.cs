using MinionProcesses.Components.Enums;
using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class Network : INetwork
    {
        public NetworkInterfaceType InterfaceType { get; set; }
        public string? InterfaceName { get; set; }
        public string? SourceName { get; set; }
        public string? MacAddress { get; set; }
        public NetworkDeviceModel DeviceModel { get; set; }
    }
}