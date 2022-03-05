using System.Collections.Generic;

namespace MinionProcesses.Components.Interfaces
{
    interface IGuest
    {
        #region Properties

        string Name { get; set; }

        string Uuid { get; set; }

        string Description { get; set; }

        string IsoPath { get; set; }

        IGuestDetails GuestDetails { get; set; }

        ICpu Cpu { get; set; }

        IMemory Memory { get; set; }

        INetwork Network { get; set; }

        ISound Sound { get; set; }

        List<IStorage> StorageDevices { get; set; }

        List<IPciDevice> PciDevices { get; set; }

        List<IUsbDevice> UsbDevices { get; set; }

        #endregion

        #region Methods

        void Create();

        void Delete(bool deleteStorage);

        void Clone(bool cloneStorage);

        void Start();

        void Stop();

        #endregion

    }
}