using MinionProcesses.Components.Interfaces;

namespace MinionProcesses.Components
{
    public class UsbDevice : IUsbDevice
    {
        public string? VendorId { get; set; }
        public string? ProductId { get; set; }
    }
}