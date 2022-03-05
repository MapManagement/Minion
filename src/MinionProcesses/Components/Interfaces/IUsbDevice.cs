namespace MinionProcesses.Components.Interfaces
{
    interface IUsbDevice
    {
        string VendorId { get; set; }

        string ProductId { get; set; }
    }
}