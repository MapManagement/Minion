using MinionProcesses.Components.Enums;

namespace MinionProcesses.Components.Interfaces
{
    public interface INetwork
    {
        NetworkInterfaceType InterfaceType { get; set; }

        string? InterfaceName { get; set; }

        string? SourceName { get; set; }

        string? MacAddress { get; set; }

        NetworkDeviceModel DeviceModel { get; set; }

    }
}